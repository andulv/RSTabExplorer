using AlphaTab.Model;
using RocksmithToolkitLib.Sng2014HSL;
using RocksmithToolkitLib.Xml;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace RockSmithTabExplorer
{
    public class RockSmithImporter
    {
        private static string GetTuningName(TuningStrings tuning, bool isBass, int capo, bool inBem = true)
        {
            List<Int32> Notes = new List<Int32>();
            List<String> NoteNames = new List<String>();
            String[] notesNames = new String[] { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
            String[] notesNamesHi = new String[] { "C", "Db", "D", "Eb", "E", "F", "Gb", "G", "Ab", "A", "Bb", "B" };
            for (Byte s = 0; s < (isBass ? 4 : 6); s++)
                Notes.Add(Sng2014FileWriter.GetMidiNote(tuning.ToShortArray(), s, 0, isBass,capo));
            foreach (var mNote in Notes)
                if (inBem) NoteNames.Add(notesNamesHi[mNote % 12]); //oct = mNote / 12 - 1
                else NoteNames.Add(notesNames[mNote % 12]); //oct = mNote / 12 - 1

            return String.Join(" ",NoteNames);
        }

        /// <param name="song"></param>
        /// <param name="difficultyLevel">null = highest level available</param>
        public static Score GetScoreForMaxDifficultyLevel(Song2014 song, int? difficultyLevel)
        {
            List<PhraseIterationWithEndTime> iterationsWithEndTime = PhraseIterationWithEndTime.listFromBaseArray(song.PhraseIterations);

            IEnumerable<SongNoteChordWrapper> allSounds = Enumerable.Empty<SongNoteChordWrapper>();

            for (int phraseId = 0; phraseId < song.Phrases.Length;phraseId++)
            {
                var phrase = song.Phrases[phraseId];
                var diffLevel = phrase.MaxDifficulty;
                if (difficultyLevel.HasValue && difficultyLevel < diffLevel)
                    diffLevel = difficultyLevel.Value;

                var selectedLevel = song.Levels.FirstOrDefault(x => x.Difficulty == diffLevel);

                var phraseIterations = iterationsWithEndTime.Where(x => x.PhraseId == phraseId).ToArray();
                for (int i = 0; i < phraseIterations.Length; i++)
                {
                    var iterationWithEndTime = phraseIterations[i];
                    var notes = selectedLevel.Notes.Where(x => iterationWithEndTime.contains(x.Time));
                    var chords = selectedLevel.Chords.Where(x => iterationWithEndTime.contains(x.Time));

                    allSounds = allSounds.Union(notes.Select(x => new SongNoteChordWrapper(x)))
                                .Union(chords.Select(x => new SongNoteChordWrapper(x)));
                }
            }
            var score = CreateSong(song, allSounds);
            return score;
        }

        /// <param name="song"></param>
        /// <param name="difficultyLevel">null = highest level available</param>
        public static Score GetScoreForExactDifficultyLevel(Song2014 song, int? difficultyLevel)
        {
            SongLevel2014 selectedLevel;

            if(difficultyLevel.HasValue)
                selectedLevel = song.Levels.FirstOrDefault(x => x.Difficulty == difficultyLevel);
            else
                selectedLevel = song.Levels.OrderBy(x => x.Difficulty).LastOrDefault();

            if (selectedLevel == null)
                return null;

            var allSounds = selectedLevel.Notes.Select(x => new SongNoteChordWrapper(x))
                            .Union(selectedLevel.Chords.Select(x => new SongNoteChordWrapper(x)));

            var score = CreateSong(song, allSounds);
            return score;
        }

        private static Score CreateSong(Song2014 song, IEnumerable<SongNoteChordWrapper> allSounds)
        {
            var score = new Score();
            score.Album = song.AlbumName;
            score.Artist = song.ArtistName;
            //score.copyright
            //score.instructions
            //score.music
            score.Notices = "Created by RockSmith Tab Explorer";
            //_score.subTitle
            //_score.tab
            score.Tempo = (int)song.AverageTempo;
            score.TempoLabel = "avg. bpm";
            score.Title = song.Title + " (" + song.Arrangement + ")";
            //_score.words

            bool isBass = song.Arrangement.ToLower() == "bass";

            var track = new Track();
            track.Name = song.Arrangement;
            track.Index = 1;
            int capo = track.Capo;
            track.TuningName = GetTuningName(song.Tuning, isBass, capo);
            track.ShortName = song.Arrangement;

            // Add string tunings in reverse order
            var tuning = new int[(isBass ? 4 : 6)];
            for (Byte s = 0; s < tuning.Length; s++)
            {
                tuning[tuning.Length - 1 - s] = Sng2014FileWriter.GetMidiNote(song.Tuning.ToShortArray(), s, 0, isBass, capo);
            }
            track.Tuning.AddRange(tuning);

            score.AddTrack(track);

            foreach (var chordTemplate in song.ChordTemplates.Where(ct=>ct.ChordId!=null))
            {
                var chord = new global::AlphaTab.Model.Chord();
                track.Chords[chordTemplate.ChordId.ToString()] = chord;

                chord.Name = chordTemplate.ChordName;
                chord.Strings.Add(chordTemplate.Fret0);
                chord.Strings.Add(chordTemplate.Fret1);
                chord.Strings.Add(chordTemplate.Fret2);
                chord.Strings.Add(chordTemplate.Fret3);
                chord.Strings.Add(chordTemplate.Fret4);
                chord.Strings.Add(chordTemplate.Fret5);
            }

            var ebeatMeasures = song.Ebeats.Where(x => x.Measure > 0).OrderBy(x => x.Measure).ToList();

            var notesStack = new Stack<SongNoteChordWrapper>(allSounds.OrderByDescending(x => x.Time));

            var currentNote = notesStack.Pop();
            var nextNote = notesStack.Pop();

            int prevMeasureId = 0;
            int i = 1;
            float prevMeasureDuration=0;
            foreach (var measure in ebeatMeasures)
            {
                var nextmeasure = i < ebeatMeasures.Count ? ebeatMeasures[i] : null;
                if (measure.Measure > prevMeasureId)
                {
                    var measureDuration = nextmeasure !=null ? nextmeasure.Time - measure.Time : prevMeasureDuration;
                    AddMasterBarToScore(score, measure.Time.ToString("n2"));
                    var voice = AddBarAndVoiceToTrack(track, isBass ? Clef.F4 : Clef.G2);

                    bool firstNoteInBar = true;
                    while (currentNote != null && (nextmeasure == null || currentNote.Time < nextmeasure.Time))
                    {
                        Duration duration = Duration.Quarter;

                        if (firstNoteInBar && currentNote.Time > measure.Time)
                        {
                            var leadingSilenceTicks = Get64thsFromDuration(measure.Time, currentNote.Time, measureDuration);
                            while (leadingSilenceTicks >= 1)
                            {
                                if (leadingSilenceTicks >= 32)
                                {
                                    AddBeatAndNoteToVoice(voice, null, Duration.Half);
                                    leadingSilenceTicks -= 32;
                                }
                                else if (leadingSilenceTicks >= 16)
                                {
                                    AddBeatAndNoteToVoice(voice, null, Duration.Quarter);
                                    leadingSilenceTicks -= 16;
                                }
                                else if (leadingSilenceTicks >= 8)
                                {
                                    AddBeatAndNoteToVoice(voice, null, Duration.Eighth);
                                    leadingSilenceTicks -= 8;
                                }
                                else if (leadingSilenceTicks >= 4)
                                {
                                    AddBeatAndNoteToVoice(voice, null, Duration.Sixteenth);
                                    leadingSilenceTicks -= 4;
                                }
                                else if (leadingSilenceTicks >= 2)
                                {
                                    AddBeatAndNoteToVoice(voice, null, Duration.ThirtySecond);
                                    leadingSilenceTicks -= 2;
                                }
                                else if (leadingSilenceTicks >= 1)
                                {
                                    AddBeatAndNoteToVoice(voice, null, Duration.SixtyFourth);
                                    leadingSilenceTicks -= 1;
                                }
                            }
                        }

                        if (nextNote != null)
                        {
                            duration = GetBeatDuration(currentNote.Time,nextNote.Time,measureDuration);
                        }

                        if (currentNote.IsNote())
                            AddBeatAndNoteToVoice(voice, currentNote.AsNote(), duration);
                        else
                            AddBeatWithChordToVoice(voice, currentNote.AsChord(), duration);

                        currentNote = nextNote;
                        if (notesStack.Any())
                            nextNote = notesStack.Pop();
                        else
                            nextNote = null;
                        firstNoteInBar = false;
                    }

                    prevMeasureId = measure.Measure;
                    prevMeasureDuration = measureDuration;
                }
                i++;
            }
            return score;
        }

        private static int GetRelativeDurationAsInt(float startTime, float endTime, float measureDuration)
        {
            return (int)Math.Round((1 / ((endTime - startTime) / measureDuration)));
        }
        private static Duration GetBeatDuration(float startTime, float endTime, float measureDuration)
        {
            var relativeDuration = GetRelativeDurationAsInt(startTime, endTime, measureDuration);
            return DurationFromInt(relativeDuration);
        }


        private static int Get64thsFromDuration(float startTime, float endTime, float measureDuration)
        {
            var duration = endTime - startTime;
            var percentDuration = duration / measureDuration;
            var retValue = percentDuration * 64.0;
            return (int)Math.Round(retValue);
        }

        private static Duration DurationFromInt(int duration)
        {
            //Whole, Half, Quarter, Eighth, Sixteenth, ThirtySecond, SixtyFourth
            if (duration > 32)
                return Duration.SixtyFourth;
            if (duration > 16)
                return Duration.ThirtySecond;
            if (duration > 8)
                return Duration.Sixteenth;
            if (duration > 4)
                return Duration.Eighth;
            if (duration > 2)
                return Duration.Quarter;
            if (duration > 1)
                return Duration.Half;

            return Duration.Whole;
        }

        private static  void AddMasterBarToScore(Score score, string sessionText)
        {
            var masterBar = new MasterBar();
            masterBar.TimeSignatureDenominator = 4;
            masterBar.TimeSignatureNumerator = 4;
            masterBar.Section = new global::AlphaTab.Model.Section() { Text = sessionText };
            score.AddMasterBar(masterBar);
        }

        private static Voice AddBarAndVoiceToTrack(Track track, Clef clef)
        {
            var bar = new Bar();
            bar.Clef = clef;
            track.AddBar(bar);
            var voice = new Voice();
            bar.AddVoice(voice);
            return voice;
        }

        private static Note _prevConvertedNote = null;

        private static void AddBeatAndNoteToVoice(Voice voice, SongNote2014 note, Duration duration)
        {
            var beat = new Beat();
            beat.Duration = duration;
            voice.AddBeat(beat);
            if (note != null)
            {
                var destNote = NoteFromNote(note);
                beat.AddNote(destNote);

                if (note.HammerOn == 1 && _prevConvertedNote != null)
                {
                    _prevConvertedNote.IsHammerPullOrigin = true;
                    //_prevConvertedNote.slideTarget = destNote;
                    //_prevConvertedNote.slideType = SlideType.Shift;
                    destNote.IsHammerPullOrigin = false;
                    destNote.IsGhost = true;
                    //_prevConvertedNote.hammerPullOrigin = destNote;// _prevConvertedNote;
                    destNote.HammerPullOrigin = _prevConvertedNote;
                }
                _prevConvertedNote = destNote;
            }
        }

        private static void AddBeatWithChordToVoice(Voice voice, SongChord2014 sourceChord, Duration duration)
        {
            var beat = new Beat();
            beat.Duration = duration;
            voice.AddBeat(beat);
            beat.ChordId = sourceChord.ChordId.ToString();
            AlphaTab.Model.Chord chord = null;
            try
            {
                chord = beat.Chord;
            }
            catch (KeyNotFoundException)
            {
            }
            

            var chordString = chord == null ? "null" : "not null";
            var sourceChordString = sourceChord.ChordNotes != null ? sourceChord.ChordNotes.Length.ToString() : "null";

            Debug.WriteLine(beat.ChordId + " - chord: " + chordString + ", sourceChord.ChordNotes: " + sourceChordString);

            //if (chord != null && sourceChord.ChordNotes.Any())
            //{
            //    DbgAssert(false);
            //}

            //Will be non-null if predefined chord exist (and predefined chord should exist if ChordId is present in ChordTemplates)
            if (chord == null)
            {
                beat.ChordId = null;
                //chord = new global::alphatab.model.Chord();
                //voice.bar.track.chords.set(beat.chordId, chord);
                
                //Set notes in beat from this chord
                if (sourceChord.ChordNotes != null)
                {
                    foreach (var sourceNote in sourceChord.ChordNotes)
                    {
                        var note1 = NoteFromNote(sourceNote);
                        beat.AddNote(note1);
                    }
                }
            }
            else
            {
                //Set notes in beat from predefined chord
                for (int i = 0; i < chord.Strings.Count; i++)
                {
                    var tmpstrFret = chord.Strings[i];
                    if (tmpstrFret > -1)
                    {
                        var note1 = new Note();
                        note1.Fret = tmpstrFret;
                        note1.String = i + 1;
                        beat.AddNote(note1);
                    }
                }          
            }


        }
        private static void DbgAssert(bool condition)
        {
            if(!condition)
                Debugger.Break();
        }

        private static Note NoteFromNote(SongNote2014 srcNote)
        {
            //DbgAssert(srcNote.LinkNext == 0);
            //DbgAssert(srcNote.Bend == 0);
            //DbgAssert(srcNote.HammerOn == 0);
            //DbgAssert(srcNote.Harmonic == 0);
            //DbgAssert(srcNote.Hopo == 0);
            //DbgAssert(srcNote.Ignore == 0);
            //DbgAssert(srcNote.Mute == 0);
            //DbgAssert(srcNote.PalmMute == 0);
            //DbgAssert(srcNote.Pluck == -1);
            //DbgAssert(srcNote.PullOff == 0);
            //DbgAssert(srcNote.Slap == -1);
            //DbgAssert(srcNote.Tremolo == 0);
            //DbgAssert(srcNote.HarmonicPinch == 0);
            //DbgAssert(srcNote.PickDirection == 0);
            //DbgAssert(srcNote.Tap == 0);
            //DbgAssert(srcNote.Vibrato == 0);

            var note1 = new Note();
            note1.Fret = srcNote.Fret;
            note1.String = srcNote.String + 1;
            note1.Accentuated = srcNote.Accent == 1 ? AccentuationType.Normal : AccentuationType.None;
            
            if (srcNote.SlideTo > -1)
                note1.SlideType = SlideType.Shift;

            if (srcNote.SlideUnpitchTo > -1)
            {
                if (srcNote.SlideUnpitchTo > srcNote.Fret)
                    note1.SlideType = SlideType.OutUp;
                else
                    note1.SlideType = SlideType.OutDown;
            }

            //note1.bendPoints          src.bend
            //note1.durationPercent
            //note1.hammerPullOrigin
            //note1.harmonicType=HarmonicType.Natural
            //note1.harmonicValue
            //note1.isDead
            //note1.isFingering
            //note1.isGhost
            //note1.isHammerPullDestination
            //note1.isHammerPullOrigin
            //note1.isLetRing
            //note1.isPalmMute
            //note1.isStaccato
            //note1.isTieDestination
            //note1.isTieOrigin
            //note1.leftHandFinger
            //note1.octave
            //note1.slideTarget
            //note1.slideType=SlideType.IntoFromAbove
            //note1.tieOrigin
            //note1.trillSpeed
            //note1.trillValue
            //note1.vibrato

            return note1;

        }




        private class SongNoteChordWrapper
        {
            protected readonly object _wrappedObject;


            public SongNoteChordWrapper(SongChord2014 wrappedObject)
            {
                _wrappedObject = wrappedObject;
                Time = wrappedObject.Time;
            }

            public SongNoteChordWrapper(SongNote2014 wrappedObject)
            {
                _wrappedObject = wrappedObject;
                Time = wrappedObject.Time;
            }


            public Single Time { get; protected set; }

            public bool IsChord()
            {
                return _wrappedObject is SongChord2014;
            }

            public SongChord2014 AsChord()
            {
                return _wrappedObject as SongChord2014;
            }

            public bool IsNote()
            {
                return _wrappedObject is SongNote2014;
            }

            public SongNote2014 AsNote()
            {
                return _wrappedObject as SongNote2014;
            }

        }

        private class PhraseIterationWithEndTime
        {
            public float EndTime;
            private SongPhraseIteration2014 phraseIteration;

            public PhraseIterationWithEndTime(SongPhraseIteration2014 _base, float _endTime)
            {
                phraseIteration = _base;
                EndTime = _endTime;
            }

            public int PhraseId
            {
                get { return phraseIteration.PhraseId; }
            }

            public float Time
            {
                get { return phraseIteration.Time; }
            }

            public bool contains(float _time)
            {
                return _time >= Time && _time < EndTime;
            }

            public static List<PhraseIterationWithEndTime> listFromBaseArray(SongPhraseIteration2014[] phraseIterations)
            {
                List<PhraseIterationWithEndTime> iterationsWithEndTime = new List<PhraseIterationWithEndTime>();
                for (int i = 0; i < phraseIterations.Length; i++)
                {
                    var thisIteration = phraseIterations[i];
                    if (i < phraseIterations.Length - 1)
                    {
                        var nextIteration = phraseIterations[i + 1];
                        iterationsWithEndTime.Add(new PhraseIterationWithEndTime(thisIteration, nextIteration.Time));
                    }
                    else
                    {
                        iterationsWithEndTime.Add(new PhraseIterationWithEndTime(thisIteration, Single.MaxValue));
                    }
                }
                return iterationsWithEndTime;
            }
        }
    }

}
