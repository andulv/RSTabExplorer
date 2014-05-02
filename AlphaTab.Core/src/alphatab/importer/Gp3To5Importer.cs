using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.importer{
	public  class Gp3To5Importer : global::alphatab.importer.ScoreImporter {
		static Gp3To5Importer() {
			global::alphatab.importer.Gp3To5Importer.VersionString = "FICHIER GUITAR PRO ";
			global::alphatab.importer.Gp3To5Importer.BendStep = ((double) (25) );
		}
		public    Gp3To5Importer(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
			}
		}
		
		
		public    Gp3To5Importer() : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
				global::alphatab.importer.Gp3To5Importer.__hx_ctor_alphatab_importer_Gp3To5Importer(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_importer_Gp3To5Importer(global::alphatab.importer.Gp3To5Importer __temp_me71){
			unchecked {
				global::alphatab.importer.ScoreImporter.__hx_ctor_alphatab_importer_ScoreImporter(__temp_me71);
				__temp_me71._globalTripletFeel = global::alphatab.model.TripletFeel.NoTripletFeel;
			}
		}
		
		
		public static  string VersionString;
		
		public static  double BendStep;
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.importer.Gp3To5Importer(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.importer.Gp3To5Importer();
			}
		}
		
		
		public  int _versionNumber;
		
		public  global::alphatab.model.Score _score;
		
		public  int _tempo;
		
		public  int _keySignature;
		
		public  int _octave;
		
		public  global::alphatab.model.TripletFeel _globalTripletFeel;
		
		public  global::haxe.root.Array<int> _lyricsIndex;
		
		public  global::haxe.root.Array<object> _lyrics;
		
		public  int _lyricsTrack;
		
		public  int _barCount;
		
		public  int _trackCount;
		
		public  global::haxe.root.Array<object> _playbackInfos;
		
		public override   global::alphatab.model.Score readScore(){
			unchecked {
				this.readVersion();
				this._score = new global::alphatab.model.Score();
				this.readScoreInformation();
				if (( this._versionNumber < 500 )) {
					if (( this._data.readByte() != 0 )) {
						this._globalTripletFeel = global::alphatab.model.TripletFeel.Triplet8th;
					}
					 else {
						this._globalTripletFeel = global::alphatab.model.TripletFeel.NoTripletFeel;
					}
					
				}
				
				if (( this._versionNumber >= 400 )) {
					this.readLyrics();
				}
				
				if (( this._versionNumber >= 510 )) {
					this._data.read(19);
				}
				
				if (( this._versionNumber >= 500 )) {
					this.readPageSetup();
					this._score.tempoLabel = this.readStringIntByte();
				}
				
				this._score.tempo = this.readInt32();
				if (( this._versionNumber >= 510 )) {
					bool __temp_expr530 = ( this._data.readByte() != 0 );
				}
				
				this._keySignature = this.readInt32();
				if (( this._versionNumber >= 400 )) {
					this._octave = this._data.readByte();
				}
				
				this.readPlaybackInfos();
				if (( this._versionNumber >= 500 )) {
					this._data.read(38);
					this._data.read(4);
				}
				
				this._barCount = this.readInt32();
				this._trackCount = this.readInt32();
				this.readMasterBars();
				this.readTracks();
				this.readBars();
				this._score.finish();
				return this._score;
			}
		}
		
		
		public virtual   void readVersion(){
			unchecked {
				string version = this.readStringByteLength(30);
				if ( ! (version.StartsWith("FICHIER GUITAR PRO ")) ) {
					throw global::haxe.lang.HaxeException.wrap(global::alphatab.importer.ScoreImporter.UnsupportedFormat);
				}
				
				version = global::haxe.lang.StringExt.substr(version, ( "FICHIER GUITAR PRO ".Length + 1 ), default(global::haxe.lang.Null<int>));
				int dot = global::haxe.lang.StringExt.indexOf(version, ".", default(global::haxe.lang.Null<int>));
				this._versionNumber = ( ( 100 * global::haxe.root.Std.parseInt(global::haxe.lang.StringExt.substr(version, 0, new global::haxe.lang.Null<int>(dot, true))).@value ) + global::haxe.root.Std.parseInt(global::haxe.lang.StringExt.substr(version, ( dot + 1 ), default(global::haxe.lang.Null<int>))).@value );
			}
		}
		
		
		public virtual   void readScoreInformation(){
			unchecked {
				this._score.title = this.readStringIntUnused();
				this._score.subTitle = this.readStringIntUnused();
				this._score.artist = this.readStringIntUnused();
				this._score.album = this.readStringIntUnused();
				this._score.words = this.readStringIntUnused();
				if (( this._versionNumber >= 500 )) {
					this._score.music = this.readStringIntUnused();
				}
				 else {
					this._score.music = this._score.words;
				}
				
				this._score.copyright = this.readStringIntUnused();
				this._score.tab = this.readStringIntUnused();
				this._score.instructions = this.readStringIntUnused();
				int noticeLines = this.readInt32();
				global::haxe.root.StringBuf notice = new global::haxe.root.StringBuf();
				{
					int _g = 0;
					while (( _g < ((int) (noticeLines) ) )){
						int i = _g++;
						if (( i > 0 )) {
							notice.b.Append(((object) ("\n") ));
						}
						
						{
							string x = this.readStringIntUnused();
							notice.b.Append(((object) (global::haxe.root.Std.@string(x)) ));
						}
						
					}
					
				}
				
				this._score.notices = notice.toString();
			}
		}
		
		
		public virtual   void readLyrics(){
			unchecked {
				this._lyrics = new global::haxe.root.Array<object>();
				this._lyricsIndex = new global::haxe.root.Array<int>();
				this._lyricsTrack = this.readInt32();
				{
					int _g = 0;
					while (( _g < 5 )){
						int i = _g++;
						this._lyricsIndex.push(( this.readInt32() - 1 ));
						this._lyrics.push(this.readString(this.readInt32()));
					}
					
				}
				
			}
		}
		
		
		public virtual   void readPageSetup(){
			unchecked {
				this._data.read(30);
				{
					int _g = 0;
					while (( _g < 10 )){
						int i = _g++;
						this.readStringIntByte();
					}
					
				}
				
			}
		}
		
		
		public virtual   void readPlaybackInfos(){
			unchecked {
				this._playbackInfos = new global::haxe.root.Array<object>();
				{
					int _g = 0;
					while (( _g < 64 )){
						int i = _g++;
						global::alphatab.model.PlaybackInformation info = new global::alphatab.model.PlaybackInformation();
						info.primaryChannel = i;
						info.secondaryChannel = i;
						info.program = this.readInt32();
						info.volume = this._data.readByte();
						info.balance = this._data.readByte();
						this._data.read(6);
						this._playbackInfos.push(info);
					}
					
				}
				
			}
		}
		
		
		public virtual   void readMasterBars(){
			unchecked {
				int _g1 = 0;
				int _g = this._barCount;
				while (( _g1 < _g )){
					int i = _g1++;
					this.readMasterBar();
				}
				
			}
		}
		
		
		public virtual   void readMasterBar(){
			unchecked {
				global::alphatab.model.MasterBar previousMasterBar = default(global::alphatab.model.MasterBar);
				if (( this._score.masterBars.length > 0 )) {
					previousMasterBar = ((global::alphatab.model.MasterBar) (this._score.masterBars[( this._score.masterBars.length - 1 )]) );
				}
				
				global::alphatab.model.MasterBar newMasterBar = new global::alphatab.model.MasterBar();
				int flags = this._data.readByte();
				if (( (( flags & 1 )) != 0 )) {
					newMasterBar.timeSignatureNumerator = this._data.readByte();
				}
				 else {
					if (( previousMasterBar != default(global::alphatab.model.MasterBar) )) {
						newMasterBar.timeSignatureNumerator = previousMasterBar.timeSignatureNumerator;
					}
					
				}
				
				if (( (( flags & 2 )) != 0 )) {
					newMasterBar.timeSignatureDenominator = this._data.readByte();
				}
				 else {
					if (( previousMasterBar != default(global::alphatab.model.MasterBar) )) {
						newMasterBar.timeSignatureDenominator = previousMasterBar.timeSignatureDenominator;
					}
					
				}
				
				newMasterBar.isRepeatStart = ( (( flags & 4 )) != 0 );
				if (( (( flags & 8 )) != 0 )) {
					if (( this._versionNumber >= 500 )) {
						newMasterBar.repeatCount = this._data.readByte();
					}
					 else {
						newMasterBar.repeatCount = 1;
					}
					
				}
				
				if (( (( flags & 32 )) != 0 )) {
					global::alphatab.model.Section section = new global::alphatab.model.Section();
					section.text = this.readStringIntByte();
					section.marker = "";
					this.readColor();
					newMasterBar.section = section;
				}
				
				if (( (( flags & 16 )) != 0 )) {
					if (( this._versionNumber < 500 )) {
						global::alphatab.model.MasterBar currentMasterBar = previousMasterBar;
						int existentAlternatives = 0;
						while (( currentMasterBar != default(global::alphatab.model.MasterBar) )){
							if (( ( currentMasterBar.repeatCount > 0 ) && ( currentMasterBar != previousMasterBar ) )) {
								break;
							}
							
							if (currentMasterBar.isRepeatStart) {
								break;
							}
							
							existentAlternatives |= currentMasterBar.alternateEndings;
						}
						
						int repeatAlternative = 0;
						int repeatMask = this._data.readByte();
						{
							int _g = 0;
							while (( _g < 8 )){
								int i = _g++;
								int repeating = ( 1 << i );
								if (( ( repeatMask > i ) && ( (( existentAlternatives & repeating )) == 0 ) )) {
									repeatAlternative |= repeating;
								}
								
							}
							
						}
						
						newMasterBar.alternateEndings = repeatAlternative;
					}
					 else {
						newMasterBar.alternateEndings = this._data.readByte();
					}
					
				}
				
				if (( (( flags & 64 )) != 0 )) {
					newMasterBar.keySignature = this._data.readInt8();
					this._data.readByte();
				}
				 else {
					if (( previousMasterBar != default(global::alphatab.model.MasterBar) )) {
						newMasterBar.keySignature = previousMasterBar.keySignature;
					}
					
				}
				
				if (( ( this._versionNumber >= 500 ) && ( (( flags & 3 )) != 0 ) )) {
					this._data.read(4);
				}
				
				if (( ( this._versionNumber >= 500 ) && ( (( flags & 16 )) == 0 ) )) {
					newMasterBar.alternateEndings = this._data.readByte();
				}
				
				if (( this._versionNumber >= 500 )) {
					int tripletFeel = this._data.readByte();
					switch (tripletFeel){
						case 1:
						{
							newMasterBar.tripletFeel = global::alphatab.model.TripletFeel.Triplet8th;
							break;
						}
						
						
						case 2:
						{
							newMasterBar.tripletFeel = global::alphatab.model.TripletFeel.Triplet16th;
							break;
						}
						
						
					}
					
					this._data.readByte();
				}
				 else {
					newMasterBar.tripletFeel = this._globalTripletFeel;
				}
				
				newMasterBar.isDoubleBar = ( (( flags & 128 )) != 0 );
				this._score.addMasterBar(newMasterBar);
			}
		}
		
		
		public virtual   void readTracks(){
			unchecked {
				int _g1 = 0;
				int _g = this._trackCount;
				while (( _g1 < _g )){
					int i = _g1++;
					this.readTrack();
				}
				
			}
		}
		
		
		public virtual   void readTrack(){
			unchecked {
				global::alphatab.model.Track newTrack = new global::alphatab.model.Track();
				this._score.addTrack(newTrack);
				int flags = this._data.readByte();
				newTrack.name = this.readStringByteLength(40);
				newTrack.isPercussion = ( (( flags & 1 )) != 0 );
				int stringCount = this.readInt32();
				{
					int _g = 0;
					while (( _g < 7 )){
						int i = _g++;
						int tuning = this.readInt32();
						if (( stringCount > i )) {
							newTrack.tuning.push(tuning);
						}
						
					}
					
				}
				
				int port = this.readInt32();
				int index = ( this.readInt32() - 1 );
				int effectChannel = ( this.readInt32() - 1 );
				this._data.read(4);
				if (( ( index >= 0 ) && ( index < this._playbackInfos.length ) )) {
					global::alphatab.model.PlaybackInformation info = ((global::alphatab.model.PlaybackInformation) (this._playbackInfos[index]) );
					info.port = port;
					info.isSolo = ( (( flags & 16 )) != 0 );
					info.isMute = ( (( flags & 32 )) != 0 );
					info.secondaryChannel = effectChannel;
					newTrack.playbackInfo = info;
				}
				
				newTrack.capo = this.readInt32();
				newTrack.color = this.readColor();
				if (( this._versionNumber >= 500 )) {
					this._data.readByte();
					this._data.readByte();
					this._data.read(43);
				}
				
				if (( this._versionNumber >= 510 )) {
					this._data.read(4);
					this.readStringIntByte();
					this.readStringIntByte();
				}
				
			}
		}
		
		
		public virtual   void readBars(){
			unchecked {
				int _g1 = 0;
				int _g = this._barCount;
				while (( _g1 < _g )){
					int b = _g1++;
					{
						int _g3 = 0;
						int _g2 = this._trackCount;
						while (( _g3 < _g2 )){
							int t = _g3++;
							this.readBar(((global::alphatab.model.Track) (this._score.tracks[t]) ));
						}
						
					}
					
				}
				
			}
		}
		
		
		public virtual   void readBar(global::alphatab.model.Track track){
			unchecked {
				global::alphatab.model.Bar newBar = new global::alphatab.model.Bar();
				if (track.isPercussion) {
					newBar.clef = global::alphatab.model.Clef.Neutral;
				}
				
				track.addBar(newBar);
				int voiceCount = 1;
				if (( this._versionNumber >= 500 )) {
					this._data.readByte();
					voiceCount = 2;
				}
				
				{
					int _g = 0;
					while (( _g < ((int) (voiceCount) ) )){
						int v = _g++;
						this.readVoice(track, newBar);
					}
					
				}
				
			}
		}
		
		
		public virtual   void readVoice(global::alphatab.model.Track track, global::alphatab.model.Bar bar){
			unchecked {
				int beatCount = this.readInt32();
				if (( beatCount == 0 )) {
					return ;
				}
				
				global::alphatab.model.Voice newVoice = new global::alphatab.model.Voice();
				bar.addVoice(newVoice);
				{
					int _g = 0;
					while (( _g < ((int) (beatCount) ) )){
						int i = _g++;
						this.readBeat(track, bar, newVoice);
					}
					
				}
				
			}
		}
		
		
		public virtual   void readBeat(global::alphatab.model.Track track, global::alphatab.model.Bar bar, global::alphatab.model.Voice voice){
			unchecked {
				global::alphatab.model.Beat newBeat = new global::alphatab.model.Beat();
				int flags = this._data.readByte();
				if (( (( flags & 1 )) != 0 )) {
					newBeat.dots = 1;
				}
				
				if (( (( flags & 64 )) != 0 )) {
					int type = this._data.readByte();
					newBeat.isEmpty = ( (( type & 2 )) == 0 );
				}
				
				voice.addBeat(newBeat);
				int duration = this._data.readInt8();
				switch (duration){
					case -2:
					{
						newBeat.duration = global::alphatab.model.Duration.Whole;
						break;
					}
					
					
					case -1:
					{
						newBeat.duration = global::alphatab.model.Duration.Half;
						break;
					}
					
					
					case 0:
					{
						newBeat.duration = global::alphatab.model.Duration.Quarter;
						break;
					}
					
					
					case 1:
					{
						newBeat.duration = global::alphatab.model.Duration.Eighth;
						break;
					}
					
					
					case 2:
					{
						newBeat.duration = global::alphatab.model.Duration.Sixteenth;
						break;
					}
					
					
					case 3:
					{
						newBeat.duration = global::alphatab.model.Duration.ThirtySecond;
						break;
					}
					
					
					case 4:
					{
						newBeat.duration = global::alphatab.model.Duration.SixtyFourth;
						break;
					}
					
					
					default:
					{
						newBeat.duration = global::alphatab.model.Duration.Quarter;
						break;
					}
					
				}
				
				if (( (( flags & 32 )) != 0 )) {
					newBeat.tupletNumerator = this.readInt32();
					{
						int _g = newBeat.tupletNumerator;
						switch (_g){
							case 1:
							{
								newBeat.tupletDenominator = 1;
								break;
							}
							
							
							case 3:
							{
								newBeat.tupletDenominator = 2;
								break;
							}
							
							
							case 5:case 6:case 7:
							{
								newBeat.tupletDenominator = 4;
								break;
							}
							
							
							case 9:case 10:case 11:case 12:case 13:
							{
								newBeat.tupletDenominator = 8;
								break;
							}
							
							
							case 2:case 4:case 8:
							{
								{
								}
								
								break;
							}
							
							
							default:
							{
								newBeat.tupletNumerator = 1;
								newBeat.tupletDenominator = 1;
								break;
							}
							
						}
						
					}
					
				}
				
				if (( (( flags & 2 )) != 0 )) {
					this.readChord(newBeat);
				}
				
				if (( (( flags & 4 )) != 0 )) {
					newBeat.text = this.readStringIntUnused();
				}
				
				if (( (( flags & 8 )) != 0 )) {
					this.readBeatEffects(newBeat);
				}
				
				if (( (( flags & 16 )) != 0 )) {
					this.readMixTableChange(newBeat);
				}
				
				int stringFlags = this._data.readByte();
				int i = 6;
				while (( i >= 0 )){
					if (( ( (( stringFlags & ( 1 << i ) )) != 0 ) && ( ( 6 - i ) < track.tuning.length ) )) {
						this.readNote(track, bar, voice, newBeat, ( 6 - i ));
					}
					
					i--;
				}
				
				if (( this._versionNumber >= 500 )) {
					this._data.readByte();
					int flag = this._data.readByte();
					if (( (( flag & 8 )) != 0 )) {
						this._data.readByte();
					}
					
				}
				
			}
		}
		
		
		public virtual   void readChord(global::alphatab.model.Beat beat){
			unchecked {
				global::alphatab.model.Chord chord = new global::alphatab.model.Chord();
				string chordId = global::alphatab.util.Guid.generate();
				if (( this._versionNumber >= 500 )) {
					this._data.read(17);
					chord.name = this.readStringByteLength(21);
					this._data.read(4);
					chord.firstFret = this.readInt32();
					{
						int _g = 0;
						while (( _g < 7 )){
							int i = _g++;
							int fret = this.readInt32();
							if (( i < chord.strings.length )) {
								chord.strings.push(fret);
							}
							
						}
						
					}
					
					this._data.read(32);
				}
				 else {
					if (( this._data.readByte() != 0 )) {
						if (( this._versionNumber >= 400 )) {
							this._data.read(16);
							chord.name = this.readStringByteLength(21);
							this._data.read(4);
							chord.firstFret = this.readInt32();
							{
								int _g1 = 0;
								while (( _g1 < 7 )){
									int i1 = _g1++;
									int fret1 = this.readInt32();
									if (( i1 < chord.strings.length )) {
										chord.strings.push(fret1);
									}
									
								}
								
							}
							
							this._data.read(32);
						}
						 else {
							this._data.read(25);
							chord.name = this.readStringByteLength(34);
							chord.firstFret = this.readInt32();
							{
								int _g2 = 0;
								while (( _g2 < 6 )){
									int i2 = _g2++;
									int fret2 = this.readInt32();
									chord.strings.push(fret2);
								}
								
							}
							
							this._data.read(36);
						}
						
					}
					 else {
						int strings = default(int);
						if (( this._versionNumber >= 406 )) {
							strings = 7;
						}
						 else {
							strings = 6;
						}
						
						chord.name = this.readStringIntByte();
						chord.firstFret = this.readInt32();
						if (( chord.firstFret > 0 )) {
							int _g3 = 0;
							while (( _g3 < strings )){
								int i3 = _g3++;
								int fret3 = this.readInt32();
								if (( i3 < chord.strings.length )) {
									chord.strings.push(fret3);
								}
								
							}
							
						}
						
					}
					
				}
				
				if (( chord.name.Length > 0 )) {
					beat.voice.bar.track.chords.@set(chordId, chord);
					beat.chordId = chordId;
				}
				
			}
		}
		
		
		public virtual   void readBeatEffects(global::alphatab.model.Beat beat){
			unchecked {
				int flags = this._data.readByte();
				int flags2 = 0;
				if (( this._versionNumber >= 400 )) {
					flags2 = this._data.readByte();
				}
				
				beat.fadeIn = ( (( flags & 16 )) != 0 );
				if (( (( flags & 2 )) != 0 )) {
					beat.vibrato = global::alphatab.model.VibratoType.Slight;
				}
				
				beat.hasRasgueado = ( (( flags2 & 1 )) != 0 );
				if (( ( (( flags & 32 )) != 0 ) && ( this._versionNumber >= 400 ) )) {
					int slapPop = this._data.readInt8();
					switch (slapPop){
						case 1:
						{
							beat.tap = true;
							break;
						}
						
						
						case 2:
						{
							beat.slap = true;
							break;
						}
						
						
						case 3:
						{
							beat.pop = true;
							break;
						}
						
						
					}
					
				}
				 else {
					if (( (( flags & 32 )) != 0 )) {
						int slapPop1 = this._data.readInt8();
						switch (slapPop1){
							case 1:
							{
								beat.tap = true;
								break;
							}
							
							
							case 2:
							{
								beat.slap = true;
								break;
							}
							
							
							case 3:
							{
								beat.pop = true;
								break;
							}
							
							
						}
						
						this._data.read(4);
					}
					
				}
				
				if (( (( flags2 & 4 )) != 0 )) {
					this.readTremoloBarEffect(beat);
				}
				
				if (( (( flags & 64 )) != 0 )) {
					int strokeUp = default(int);
					int strokeDown = default(int);
					if (( this._versionNumber < 500 )) {
						strokeDown = this._data.readByte();
						strokeUp = this._data.readByte();
					}
					 else {
						strokeUp = this._data.readByte();
						strokeDown = this._data.readByte();
					}
					
					if (( strokeUp > 0 )) {
						beat.brushType = global::alphatab.model.BrushType.BrushUp;
						beat.brushDuration = this.toStrokeValue(strokeUp);
					}
					 else {
						if (( strokeDown > 0 )) {
							beat.brushType = global::alphatab.model.BrushType.BrushDown;
							beat.brushDuration = this.toStrokeValue(strokeDown);
						}
						
					}
					
				}
				
				if (( (( flags2 & 2 )) != 0 )) {
					int _g = this._data.readInt8();
					switch (_g){
						case 0:
						{
							beat.pickStroke = global::alphatab.model.PickStrokeType.None;
							break;
						}
						
						
						case 1:
						{
							beat.pickStroke = global::alphatab.model.PickStrokeType.Up;
							break;
						}
						
						
						case 2:
						{
							beat.pickStroke = global::alphatab.model.PickStrokeType.Down;
							break;
						}
						
						
					}
					
				}
				
			}
		}
		
		
		public virtual   void readTremoloBarEffect(global::alphatab.model.Beat beat){
			unchecked {
				this._data.readByte();
				this.readInt32();
				int pointCount = this.readInt32();
				if (( pointCount > 0 )) {
					int _g = 0;
					while (( _g < ((int) (pointCount) ) )){
						int i = _g++;
						global::alphatab.model.BendPoint point = new global::alphatab.model.BendPoint(((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ));
						point.offset = this.readInt32();
						{
							double x = ( this.readInt32() / ((double) (25) ) );
							point.@value = ((int) (x) );
						}
						
						bool __temp_expr531 = ( this._data.readByte() != 0 );
						beat.whammyBarPoints.push(point);
					}
					
				}
				
			}
		}
		
		
		public virtual   int toStrokeValue(int @value){
			unchecked {
				switch (@value){
					case 1:
					{
						return 30;
					}
					
					
					case 2:
					{
						return 30;
					}
					
					
					case 3:
					{
						return 60;
					}
					
					
					case 4:
					{
						return 120;
					}
					
					
					case 5:
					{
						return 240;
					}
					
					
					case 6:
					{
						return 480;
					}
					
					
					default:
					{
						return 0;
					}
					
				}
				
			}
		}
		
		
		public virtual   void readMixTableChange(global::alphatab.model.Beat beat){
			unchecked {
				global::alphatab.importer.MixTableChange tableChange = new global::alphatab.importer.MixTableChange();
				tableChange.instrument = this._data.readInt8();
				if (( this._versionNumber >= 500 )) {
					this._data.read(16);
				}
				
				tableChange.volume = this._data.readInt8();
				tableChange.balance = this._data.readInt8();
				int chorus = this._data.readInt8();
				int reverb = this._data.readInt8();
				int phaser = this._data.readInt8();
				int tremolo = this._data.readInt8();
				if (( this._versionNumber >= 500 )) {
					tableChange.tempoName = this.readStringIntByte();
				}
				
				tableChange.tempo = this.readInt32();
				if (( tableChange.volume >= 0 )) {
					this._data.readByte();
				}
				
				if (( tableChange.balance >= 0 )) {
					this._data.readByte();
				}
				
				if (( chorus >= 0 )) {
					this._data.readByte();
				}
				
				if (( reverb >= 0 )) {
					this._data.readByte();
				}
				
				if (( phaser >= 0 )) {
					this._data.readByte();
				}
				
				if (( tremolo >= 0 )) {
					this._data.readByte();
				}
				
				if (( tableChange.tempo >= 0 )) {
					tableChange.duration = this._data.readInt8();
					if (( this._versionNumber >= 510 )) {
						this._data.readByte();
					}
					
				}
				
				if (( this._versionNumber >= 400 )) {
					this._data.readByte();
				}
				
				if (( this._versionNumber >= 500 )) {
					this._data.readByte();
				}
				
				if (( this._versionNumber >= 510 )) {
					this.readStringIntByte();
					this.readStringIntByte();
				}
				
				if (( tableChange.volume >= 0 )) {
					global::alphatab.model.Automation volumeAutomation = new global::alphatab.model.Automation();
					volumeAutomation.isLinear = true;
					volumeAutomation.type = global::alphatab.model.AutomationType.Volume;
					volumeAutomation.@value = ((double) (tableChange.volume) );
					beat.automations.push(volumeAutomation);
				}
				
				if (( tableChange.balance >= 0 )) {
					global::alphatab.model.Automation balanceAutomation = new global::alphatab.model.Automation();
					balanceAutomation.isLinear = true;
					balanceAutomation.type = global::alphatab.model.AutomationType.Balance;
					balanceAutomation.@value = ((double) (tableChange.balance) );
					beat.automations.push(balanceAutomation);
				}
				
				if (( tableChange.instrument >= 0 )) {
					global::alphatab.model.Automation instrumentAutomation = new global::alphatab.model.Automation();
					instrumentAutomation.isLinear = true;
					instrumentAutomation.type = global::alphatab.model.AutomationType.Instrument;
					instrumentAutomation.@value = ((double) (tableChange.instrument) );
					beat.automations.push(instrumentAutomation);
				}
				
				if (( tableChange.tempo >= 0 )) {
					global::alphatab.model.Automation tempoAutomation = new global::alphatab.model.Automation();
					tempoAutomation.isLinear = true;
					tempoAutomation.type = global::alphatab.model.AutomationType.Tempo;
					tempoAutomation.@value = ((double) (tableChange.tempo) );
					beat.automations.push(tempoAutomation);
					global::alphatab.model.MasterBar __temp_stmt532 = default(global::alphatab.model.MasterBar);
					{
						global::alphatab.model.Bar _this = beat.voice.bar;
						__temp_stmt532 = ((global::alphatab.model.MasterBar) (_this.track.score.masterBars[_this.index]) );
					}
					
					__temp_stmt532.tempoAutomation = tempoAutomation;
				}
				
			}
		}
		
		
		public virtual   void readNote(global::alphatab.model.Track track, global::alphatab.model.Bar bar, global::alphatab.model.Voice voice, global::alphatab.model.Beat beat, int stringIndex){
			unchecked {
				global::alphatab.model.Note newNote = new global::alphatab.model.Note();
				newNote.@string = ( track.tuning.length - stringIndex );
				int flags = this._data.readByte();
				if (( (( flags & 2 )) != 0 )) {
					newNote.accentuated = global::alphatab.model.AccentuationType.Heavy;
				}
				 else {
					if (( (( flags & 64 )) != 0 )) {
						newNote.accentuated = global::alphatab.model.AccentuationType.Normal;
					}
					
				}
				
				newNote.isGhost = ( (( flags & 4 )) != 0 );
				if (( (( flags & 32 )) != 0 )) {
					int noteType = this._data.readByte();
					if (( noteType == 3 )) {
						newNote.isDead = true;
					}
					 else {
						if (( noteType == 2 )) {
							newNote.isTieDestination = true;
						}
						
					}
					
				}
				
				if (( (( flags & 16 )) != 0 )) {
					int dynamicNumber = this._data.readInt8();
					newNote.dynamicValue = this.toDynamicValue(dynamicNumber);
					beat.dynamicValue = newNote.dynamicValue;
				}
				
				if (( (( flags & 32 )) != 0 )) {
					newNote.fret = this._data.readInt8();
				}
				
				if (( (( flags & 128 )) != 0 )) {
					newNote.leftHandFinger = this._data.readInt8();
					newNote.rightHandFinger = this._data.readInt8();
					newNote.isFingering = true;
				}
				
				if (( this._versionNumber >= 500 )) {
					if (( (( flags & 1 )) != 0 )) {
						newNote.durationPercent = this.readDouble();
					}
					
					int flags2 = this._data.readByte();
					newNote.swapAccidentals = ( (( flags2 & 2 )) != 0 );
				}
				
				beat.addNote(newNote);
				if (( (( flags & 8 )) != 0 )) {
					this.readNoteEffects(track, voice, beat, newNote);
				}
				
			}
		}
		
		
		public virtual   global::alphatab.model.DynamicValue toDynamicValue(int @value){
			unchecked {
				switch (@value){
					case 1:
					{
						return global::alphatab.model.DynamicValue.PPP;
					}
					
					
					case 2:
					{
						return global::alphatab.model.DynamicValue.PP;
					}
					
					
					case 3:
					{
						return global::alphatab.model.DynamicValue.P;
					}
					
					
					case 4:
					{
						return global::alphatab.model.DynamicValue.MP;
					}
					
					
					case 5:
					{
						return global::alphatab.model.DynamicValue.MF;
					}
					
					
					case 6:
					{
						return global::alphatab.model.DynamicValue.F;
					}
					
					
					case 7:
					{
						return global::alphatab.model.DynamicValue.FF;
					}
					
					
					case 8:
					{
						return global::alphatab.model.DynamicValue.FFF;
					}
					
					
					default:
					{
						return global::alphatab.model.DynamicValue.F;
					}
					
				}
				
			}
		}
		
		
		public virtual   void readNoteEffects(global::alphatab.model.Track track, global::alphatab.model.Voice voice, global::alphatab.model.Beat beat, global::alphatab.model.Note note){
			unchecked {
				int flags = this._data.readByte();
				int flags2 = 0;
				if (( this._versionNumber >= 400 )) {
					flags2 = this._data.readByte();
				}
				
				if (( (( flags & 1 )) != 0 )) {
					this.readBend(note);
				}
				
				if (( (( flags & 16 )) != 0 )) {
					this.readGrace(voice, note);
				}
				
				if (( (( flags2 & 4 )) != 0 )) {
					this.readTremoloPicking(beat);
				}
				
				if (( (( flags2 & 8 )) != 0 )) {
					this.readSlide(note);
				}
				 else {
					if (( this._versionNumber < 400 )) {
						if (( (( flags & 4 )) != 0 )) {
							note.slideType = global::alphatab.model.SlideType.Shift;
						}
						
					}
					
				}
				
				if (( (( flags2 & 16 )) != 0 )) {
					this.readArtificialHarmonic(note);
				}
				 else {
					if (( this._versionNumber < 400 )) {
						if (( (( flags & 4 )) != 0 )) {
							note.harmonicType = global::alphatab.model.HarmonicType.Natural;
							note.harmonicValue = this.deltaFretToHarmonicValue(note.fret);
						}
						
						if (( (( flags & 8 )) != 0 )) {
							note.harmonicType = global::alphatab.model.HarmonicType.Artificial;
						}
						
					}
					
				}
				
				if (( (( flags2 & 32 )) != 0 )) {
					this.readTrill(note);
				}
				
				note.isLetRing = ( (( flags & 8 )) != 0 );
				note.isHammerPullOrigin = ( (( flags & 2 )) != 0 );
				if (( (( flags2 & 64 )) != 0 )) {
					note.vibrato = global::alphatab.model.VibratoType.Slight;
				}
				
				note.isPalmMute = ( (( flags2 & 2 )) != 0 );
				note.isStaccato = ( (( flags2 & 1 )) != 0 );
			}
		}
		
		
		public virtual   void readBend(global::alphatab.model.Note note){
			unchecked {
				this._data.readByte();
				this.readInt32();
				int pointCount = this.readInt32();
				if (( pointCount > 0 )) {
					int _g = 0;
					while (( _g < ((int) (pointCount) ) )){
						int i = _g++;
						global::alphatab.model.BendPoint point = new global::alphatab.model.BendPoint(((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ));
						point.offset = this.readInt32();
						{
							double x = ( this.readInt32() / ((double) (25) ) );
							point.@value = ((int) (x) );
						}
						
						bool __temp_expr533 = ( this._data.readByte() != 0 );
						note.bendPoints.push(point);
					}
					
				}
				
			}
		}
		
		
		public virtual   void readGrace(global::alphatab.model.Voice voice, global::alphatab.model.Note note){
			unchecked {
				global::alphatab.model.Beat graceBeat = new global::alphatab.model.Beat();
				global::alphatab.model.Note graceNote = new global::alphatab.model.Note();
				graceNote.@string = note.@string;
				graceNote.fret = this._data.readInt8();
				graceBeat.duration = global::alphatab.model.Duration.ThirtySecond;
				graceBeat.dynamicValue = this.toDynamicValue(this._data.readInt8());
				int transition = this._data.readInt8();
				switch (transition){
					case 0:
					{
						{
						}
						
						break;
					}
					
					
					case 1:
					{
						graceNote.slideType = global::alphatab.model.SlideType.Legato;
						graceNote.slideTarget = note;
						break;
					}
					
					
					case 2:
					{
						{
						}
						
						break;
					}
					
					
					case 3:
					{
						graceNote.isHammerPullOrigin = true;
						note.isHammerPullDestination = true;
						note.hammerPullOrigin = graceNote;
						break;
					}
					
					
				}
				
				graceNote.dynamicValue = graceBeat.dynamicValue;
				this._data.read(1);
				if (( this._versionNumber < 500 )) {
					graceBeat.graceType = global::alphatab.model.GraceType.BeforeBeat;
				}
				 else {
					int flags = this._data.readByte();
					graceNote.isDead = ( (( flags & 1 )) != 0 );
					if (( (( flags & 2 )) != 0 )) {
						graceBeat.graceType = global::alphatab.model.GraceType.OnBeat;
					}
					 else {
						graceBeat.graceType = global::alphatab.model.GraceType.BeforeBeat;
					}
					
				}
				
				graceBeat.addNote(graceNote);
				voice.addGraceBeat(graceBeat);
			}
		}
		
		
		public virtual   void readTremoloPicking(global::alphatab.model.Beat beat){
			unchecked {
				int speed = this._data.readByte();
				switch (speed){
					case 1:
					{
						beat.tremoloSpeed = new global::haxe.lang.Null<global::alphatab.model.Duration>(global::alphatab.model.Duration.Eighth, true);
						break;
					}
					
					
					case 2:
					{
						beat.tremoloSpeed = new global::haxe.lang.Null<global::alphatab.model.Duration>(global::alphatab.model.Duration.Sixteenth, true);
						break;
					}
					
					
					case 3:
					{
						beat.tremoloSpeed = new global::haxe.lang.Null<global::alphatab.model.Duration>(global::alphatab.model.Duration.ThirtySecond, true);
						break;
					}
					
					
				}
				
			}
		}
		
		
		public virtual   void readSlide(global::alphatab.model.Note note){
			unchecked {
				if (( this._versionNumber >= 500 )) {
					int type = this._data.readByte();
					switch (type){
						case 1:
						{
							note.slideType = global::alphatab.model.SlideType.Shift;
							break;
						}
						
						
						case 2:
						{
							note.slideType = global::alphatab.model.SlideType.Legato;
							break;
						}
						
						
						case 4:
						{
							note.slideType = global::alphatab.model.SlideType.OutDown;
							break;
						}
						
						
						case 8:
						{
							note.slideType = global::alphatab.model.SlideType.OutUp;
							break;
						}
						
						
						case 16:
						{
							note.slideType = global::alphatab.model.SlideType.IntoFromBelow;
							break;
						}
						
						
						case 32:
						{
							note.slideType = global::alphatab.model.SlideType.IntoFromAbove;
							break;
						}
						
						
						default:
						{
							note.slideType = global::alphatab.model.SlideType.None;
							break;
						}
						
					}
					
				}
				 else {
					int type1 = this._data.readInt8();
					switch (type1){
						case 1:
						{
							note.slideType = global::alphatab.model.SlideType.Shift;
							break;
						}
						
						
						case 2:
						{
							note.slideType = global::alphatab.model.SlideType.Legato;
							break;
						}
						
						
						case 3:
						{
							note.slideType = global::alphatab.model.SlideType.OutDown;
							break;
						}
						
						
						case 4:
						{
							note.slideType = global::alphatab.model.SlideType.OutUp;
							break;
						}
						
						
						case -1:
						{
							note.slideType = global::alphatab.model.SlideType.IntoFromBelow;
							break;
						}
						
						
						case -2:
						{
							note.slideType = global::alphatab.model.SlideType.IntoFromAbove;
							break;
						}
						
						
						default:
						{
							note.slideType = global::alphatab.model.SlideType.None;
							break;
						}
						
					}
					
				}
				
			}
		}
		
		
		public virtual   void readArtificialHarmonic(global::alphatab.model.Note note){
			unchecked {
				int type = this._data.readByte();
				if (( this._versionNumber >= 500 )) {
					switch (type){
						case 1:
						{
							note.harmonicType = global::alphatab.model.HarmonicType.Natural;
							note.harmonicValue = this.deltaFretToHarmonicValue(note.fret);
							break;
						}
						
						
						case 2:
						{
							int harmonicTone = this._data.readByte();
							int harmonicKey = this._data.readByte();
							int harmonicOctaveOffset = this._data.readByte();
							note.harmonicType = global::alphatab.model.HarmonicType.Artificial;
							break;
						}
						
						
						case 3:
						{
							note.harmonicType = global::alphatab.model.HarmonicType.Tap;
							note.harmonicValue = this.deltaFretToHarmonicValue(this._data.readByte());
							break;
						}
						
						
						case 4:
						{
							note.harmonicType = global::alphatab.model.HarmonicType.Pinch;
							note.harmonicValue = ((double) (12) );
							break;
						}
						
						
						case 5:
						{
							note.harmonicType = global::alphatab.model.HarmonicType.Semi;
							note.harmonicValue = ((double) (12) );
							break;
						}
						
						
					}
					
				}
				 else {
					if (( this._versionNumber >= 400 )) {
						switch (type){
							case 1:
							{
								note.harmonicType = global::alphatab.model.HarmonicType.Natural;
								note.harmonicValue = this.deltaFretToHarmonicValue(note.fret);
								break;
							}
							
							
							case 3:
							{
								note.harmonicType = global::alphatab.model.HarmonicType.Tap;
								break;
							}
							
							
							case 4:
							{
								note.harmonicType = global::alphatab.model.HarmonicType.Pinch;
								note.harmonicValue = ((double) (12) );
								break;
							}
							
							
							case 5:
							{
								note.harmonicType = global::alphatab.model.HarmonicType.Semi;
								note.harmonicValue = ((double) (12) );
								break;
							}
							
							
							case 15:
							{
								note.harmonicType = global::alphatab.model.HarmonicType.Artificial;
								note.harmonicValue = this.deltaFretToHarmonicValue(( note.fret + 5 ));
								break;
							}
							
							
							case 17:
							{
								note.harmonicType = global::alphatab.model.HarmonicType.Artificial;
								note.harmonicValue = this.deltaFretToHarmonicValue(( note.fret + 7 ));
								break;
							}
							
							
							case 22:
							{
								note.harmonicType = global::alphatab.model.HarmonicType.Artificial;
								note.harmonicValue = this.deltaFretToHarmonicValue(( note.fret + 12 ));
								break;
							}
							
							
							default:
							{
								{
								}
								
								break;
							}
							
						}
						
					}
					
				}
				
			}
		}
		
		
		public virtual   double deltaFretToHarmonicValue(int deltaFret){
			unchecked {
				switch (deltaFret){
					case 2:
					{
						return 2.4;
					}
					
					
					case 3:
					{
						return 3.2;
					}
					
					
					case 4:case 5:case 7:case 9:case 12:case 16:case 17:case 19:case 24:
					{
						return ((double) (deltaFret) );
					}
					
					
					case 8:
					{
						return 8.2;
					}
					
					
					case 10:
					{
						return 9.6;
					}
					
					
					case 14:case 15:
					{
						return 14.7;
					}
					
					
					case 21:case 22:
					{
						return 21.7;
					}
					
					
					default:
					{
						return ((double) (12) );
					}
					
				}
				
			}
		}
		
		
		public virtual   void readTrill(global::alphatab.model.Note note){
			unchecked {
				note.trillValue = ( this._data.readByte() + note.beat.voice.bar.track.tuning[( ( note.beat.voice.bar.track.tuning.length - (( note.@string - 1 )) ) - 1 )] );
				{
					int _g = this._data.readByte();
					switch (_g){
						case 1:
						{
							note.trillSpeed = global::alphatab.model.Duration.Sixteenth;
							break;
						}
						
						
						case 2:
						{
							note.trillSpeed = global::alphatab.model.Duration.ThirtySecond;
							break;
						}
						
						
						case 3:
						{
							note.trillSpeed = global::alphatab.model.Duration.SixtyFourth;
							break;
						}
						
						
					}
					
				}
				
			}
		}
		
		
		public virtual   double readDouble(){
			unchecked {
				global::haxe.io.Bytes bytes = global::haxe.io.Bytes.alloc(8);
				this._data.readBytes(bytes, 0, 8);
				global::haxe.root.Array<int> indices = default(global::haxe.root.Array<int>);
				if ( ! (this._data.bigEndian) ) {
					indices = new global::haxe.root.Array<int>(new int[]{7, 6, 5, 4, 3, 2, 1, 0});
				}
				 else {
					indices = new global::haxe.root.Array<int>(new int[]{0, 1, 2, 3, 4, 5, 6, 7});
				}
				
				int sign = ( 1 - (( ( ((int) (bytes.b[indices[0]]) ) >> 7 ) << 1 )) );
				int exp = ( (( ( ( ((int) (bytes.b[indices[0]]) ) << 4 ) & 2047 ) | ( ((int) (bytes.b[indices[1]]) ) >> 4 ) )) - 1023 );
				int sig = this.getDoubleSig(bytes, indices);
				if (( ( sig == 0 ) && ( exp == -1023 ) )) {
					return 0.0;
				}
				
				return ( ( sign * (( 1.0 + ( global::System.Math.Pow(((double) (2) ), ((double) (-52) )) * sig ) )) ) * global::System.Math.Pow(((double) (2) ), ((double) (exp) )) );
			}
		}
		
		
		public virtual   int getDoubleSig(global::haxe.io.Bytes bytes, global::haxe.root.Array<int> indices){
			unchecked {
				return ( ( ( ( ( ( ( (( ((int) (bytes.b[indices[1]]) ) & 15 )) << 48 ) | ( ((int) (bytes.b[indices[2]]) ) << 40 ) ) | ( ((int) (bytes.b[indices[3]]) ) << 32 ) ) | ( ((int) (bytes.b[indices[4]]) ) << 24 ) ) | ( ((int) (bytes.b[indices[5]]) ) << 16 ) ) | ( ((int) (bytes.b[indices[6]]) ) << 8 ) ) | ((int) (bytes.b[indices[7]]) ) );
			}
		}
		
		
		public virtual   global::alphatab.platform.model.Color readColor(){
			unchecked {
				int r = this._data.readByte();
				int g = this._data.readByte();
				int b = this._data.readByte();
				this._data.read(1);
				return new global::alphatab.platform.model.Color(((int) (r) ), ((int) (g) ), ((int) (b) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ));
			}
		}
		
		
		public   bool readBool(){
			unchecked {
				return ( this._data.readByte() != 0 );
			}
		}
		
		
		public   int readUInt8(){
			unchecked {
				return this._data.readByte();
			}
		}
		
		
		public virtual   int readInt32(){
			unchecked {
				int ch1 = this._data.readByte();
				int ch2 = this._data.readByte();
				int ch3 = this._data.readByte();
				int ch4 = this._data.readByte();
				return ( ( ( ch1 | ( ch2 << 8 ) ) | ( ch3 << 16 ) ) | ( ch4 << 24 ) );
			}
		}
		
		
		public virtual   string readStringIntUnused(){
			unchecked {
				this._data.read(4);
				return this.readString(this._data.readByte());
			}
		}
		
		
		public   string readStringInt(){
			unchecked {
				return this.readString(this.readInt32());
			}
		}
		
		
		public virtual   string readStringIntByte(){
			unchecked {
				int length = ( this.readInt32() - 1 );
				this._data.readByte();
				return this.readString(length);
			}
		}
		
		
		public virtual   string readString(int length){
			unchecked {
				global::haxe.io.Bytes b = global::haxe.io.Bytes.alloc(length);
				this._data.readFullBytes(b, 0, length);
				return global::System.Text.Encoding.Default.GetString(((byte[]) (b.b) ), ((int) (0) ), ((int) (length) ));
			}
		}
		
		
		public virtual   string readStringByteLength(int length){
			unchecked {
				int stringLength = this._data.readByte();
				string @string = this.readString(stringLength);
				if (( stringLength < length )) {
					this._data.read(( length - stringLength ));
				}
				
				return @string;
			}
		}
		
		
		public   void skip(int count){
			unchecked {
				this._data.read(count);
			}
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 1249074019:
					{
						this._trackCount = ((int) (@value) );
						return @value;
					}
					
					
					case 1623686491:
					{
						this._barCount = ((int) (@value) );
						return @value;
					}
					
					
					case 1164415160:
					{
						this._lyricsTrack = ((int) (@value) );
						return @value;
					}
					
					
					case 498486927:
					{
						this._octave = ((int) (@value) );
						return @value;
					}
					
					
					case 1336074296:
					{
						this._keySignature = ((int) (@value) );
						return @value;
					}
					
					
					case 158873116:
					{
						this._tempo = ((int) (@value) );
						return @value;
					}
					
					
					case 540881986:
					{
						this._versionNumber = ((int) (@value) );
						return @value;
					}
					
					
					default:
					{
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 1368126571:
					{
						this._playbackInfos = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					case 1249074019:
					{
						this._trackCount = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1623686491:
					{
						this._barCount = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1164415160:
					{
						this._lyricsTrack = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 338202835:
					{
						this._lyrics = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					case 1834786111:
					{
						this._lyricsIndex = ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					case 822594234:
					{
						this._globalTripletFeel = ((global::alphatab.model.TripletFeel) (@value) );
						return @value;
					}
					
					
					case 498486927:
					{
						this._octave = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1336074296:
					{
						this._keySignature = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 158873116:
					{
						this._tempo = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1958787731:
					{
						this._score = ((global::alphatab.model.Score) (@value) );
						return @value;
					}
					
					
					case 540881986:
					{
						this._versionNumber = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					default:
					{
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties){
			unchecked {
				switch (hash){
					case 1280644735:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("skip") ), ((int) (1280644735) ))) );
					}
					
					
					case 559254965:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("readStringByteLength") ), ((int) (559254965) ))) );
					}
					
					
					case 179047623:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("readString") ), ((int) (179047623) ))) );
					}
					
					
					case 62672272:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("readStringIntByte") ), ((int) (62672272) ))) );
					}
					
					
					case 1529130600:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("readStringInt") ), ((int) (1529130600) ))) );
					}
					
					
					case 1772779934:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("readStringIntUnused") ), ((int) (1772779934) ))) );
					}
					
					
					case 252174360:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("readInt32") ), ((int) (252174360) ))) );
					}
					
					
					case 1599970376:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("readUInt8") ), ((int) (1599970376) ))) );
					}
					
					
					case 1762877088:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("readBool") ), ((int) (1762877088) ))) );
					}
					
					
					case 457424429:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("readColor") ), ((int) (457424429) ))) );
					}
					
					
					case 1695828234:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getDoubleSig") ), ((int) (1695828234) ))) );
					}
					
					
					case 742854407:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("readDouble") ), ((int) (742854407) ))) );
					}
					
					
					case 1728902453:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("readTrill") ), ((int) (1728902453) ))) );
					}
					
					
					case 29588086:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("deltaFretToHarmonicValue") ), ((int) (29588086) ))) );
					}
					
					
					case 1776938941:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("readArtificialHarmonic") ), ((int) (1776938941) ))) );
					}
					
					
					case 1336873467:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("readSlide") ), ((int) (1336873467) ))) );
					}
					
					
					case 854748907:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("readTremoloPicking") ), ((int) (854748907) ))) );
					}
					
					
					case 1792102594:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("readGrace") ), ((int) (1792102594) ))) );
					}
					
					
					case 1762379567:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("readBend") ), ((int) (1762379567) ))) );
					}
					
					
					case 152811322:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("readNoteEffects") ), ((int) (152811322) ))) );
					}
					
					
					case 628441485:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("toDynamicValue") ), ((int) (628441485) ))) );
					}
					
					
					case 1895953000:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("readNote") ), ((int) (1895953000) ))) );
					}
					
					
					case 1559296472:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("readMixTableChange") ), ((int) (1559296472) ))) );
					}
					
					
					case 1272889054:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("toStrokeValue") ), ((int) (1272889054) ))) );
					}
					
					
					case 1401458574:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("readTremoloBarEffect") ), ((int) (1401458574) ))) );
					}
					
					
					case 768599606:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("readBeatEffects") ), ((int) (768599606) ))) );
					}
					
					
					case 379947302:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("readChord") ), ((int) (379947302) ))) );
					}
					
					
					case 1762376684:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("readBeat") ), ((int) (1762376684) ))) );
					}
					
					
					case 199127676:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("readVoice") ), ((int) (199127676) ))) );
					}
					
					
					case 46422045:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("readBar") ), ((int) (46422045) ))) );
					}
					
					
					case 1762181558:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("readBars") ), ((int) (1762181558) ))) );
					}
					
					
					case 1728502613:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("readTrack") ), ((int) (1728502613) ))) );
					}
					
					
					case 1056509822:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("readTracks") ), ((int) (1056509822) ))) );
					}
					
					
					case 316994587:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("readMasterBar") ), ((int) (316994587) ))) );
					}
					
					
					case 1970316280:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("readMasterBars") ), ((int) (1970316280) ))) );
					}
					
					
					case 1086991092:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("readPlaybackInfos") ), ((int) (1086991092) ))) );
					}
					
					
					case 867499896:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("readPageSetup") ), ((int) (867499896) ))) );
					}
					
					
					case 523068202:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("readLyrics") ), ((int) (523068202) ))) );
					}
					
					
					case 1244852144:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("readScoreInformation") ), ((int) (1244852144) ))) );
					}
					
					
					case 1339914850:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("readVersion") ), ((int) (1339914850) ))) );
					}
					
					
					case 1237368860:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("readScore") ), ((int) (1237368860) ))) );
					}
					
					
					case 1368126571:
					{
						return this._playbackInfos;
					}
					
					
					case 1249074019:
					{
						return this._trackCount;
					}
					
					
					case 1623686491:
					{
						return this._barCount;
					}
					
					
					case 1164415160:
					{
						return this._lyricsTrack;
					}
					
					
					case 338202835:
					{
						return this._lyrics;
					}
					
					
					case 1834786111:
					{
						return this._lyricsIndex;
					}
					
					
					case 822594234:
					{
						return this._globalTripletFeel;
					}
					
					
					case 498486927:
					{
						return this._octave;
					}
					
					
					case 1336074296:
					{
						return this._keySignature;
					}
					
					
					case 158873116:
					{
						return this._tempo;
					}
					
					
					case 1958787731:
					{
						return this._score;
					}
					
					
					case 540881986:
					{
						return this._versionNumber;
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties){
			unchecked {
				switch (hash){
					case 1249074019:
					{
						return ((double) (this._trackCount) );
					}
					
					
					case 1623686491:
					{
						return ((double) (this._barCount) );
					}
					
					
					case 1164415160:
					{
						return ((double) (this._lyricsTrack) );
					}
					
					
					case 498486927:
					{
						return ((double) (this._octave) );
					}
					
					
					case 1336074296:
					{
						return ((double) (this._keySignature) );
					}
					
					
					case 158873116:
					{
						return ((double) (this._tempo) );
					}
					
					
					case 540881986:
					{
						return ((double) (this._versionNumber) );
					}
					
					
					default:
					{
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   object __hx_invokeField(string field, int hash, global::haxe.root.Array dynargs){
			unchecked {
				switch (hash){
					case 1237368860:
					{
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 1280644735:
					{
						this.skip(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
						break;
					}
					
					
					case 559254965:
					{
						return this.readStringByteLength(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
					}
					
					
					case 179047623:
					{
						return this.readString(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
					}
					
					
					case 62672272:
					{
						return this.readStringIntByte();
					}
					
					
					case 1529130600:
					{
						return this.readStringInt();
					}
					
					
					case 1772779934:
					{
						return this.readStringIntUnused();
					}
					
					
					case 252174360:
					{
						return this.readInt32();
					}
					
					
					case 1599970376:
					{
						return this.readUInt8();
					}
					
					
					case 1762877088:
					{
						return this.readBool();
					}
					
					
					case 457424429:
					{
						return this.readColor();
					}
					
					
					case 1695828234:
					{
						return this.getDoubleSig(((global::haxe.io.Bytes) (dynargs[0]) ), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (dynargs[1]) ))) ));
					}
					
					
					case 742854407:
					{
						return this.readDouble();
					}
					
					
					case 1728902453:
					{
						this.readTrill(((global::alphatab.model.Note) (dynargs[0]) ));
						break;
					}
					
					
					case 29588086:
					{
						return this.deltaFretToHarmonicValue(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
					}
					
					
					case 1776938941:
					{
						this.readArtificialHarmonic(((global::alphatab.model.Note) (dynargs[0]) ));
						break;
					}
					
					
					case 1336873467:
					{
						this.readSlide(((global::alphatab.model.Note) (dynargs[0]) ));
						break;
					}
					
					
					case 854748907:
					{
						this.readTremoloPicking(((global::alphatab.model.Beat) (dynargs[0]) ));
						break;
					}
					
					
					case 1792102594:
					{
						this.readGrace(((global::alphatab.model.Voice) (dynargs[0]) ), ((global::alphatab.model.Note) (dynargs[1]) ));
						break;
					}
					
					
					case 1762379567:
					{
						this.readBend(((global::alphatab.model.Note) (dynargs[0]) ));
						break;
					}
					
					
					case 152811322:
					{
						this.readNoteEffects(((global::alphatab.model.Track) (dynargs[0]) ), ((global::alphatab.model.Voice) (dynargs[1]) ), ((global::alphatab.model.Beat) (dynargs[2]) ), ((global::alphatab.model.Note) (dynargs[3]) ));
						break;
					}
					
					
					case 628441485:
					{
						return this.toDynamicValue(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
					}
					
					
					case 1895953000:
					{
						this.readNote(((global::alphatab.model.Track) (dynargs[0]) ), ((global::alphatab.model.Bar) (dynargs[1]) ), ((global::alphatab.model.Voice) (dynargs[2]) ), ((global::alphatab.model.Beat) (dynargs[3]) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[4])) ));
						break;
					}
					
					
					case 1559296472:
					{
						this.readMixTableChange(((global::alphatab.model.Beat) (dynargs[0]) ));
						break;
					}
					
					
					case 1272889054:
					{
						return this.toStrokeValue(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
					}
					
					
					case 1401458574:
					{
						this.readTremoloBarEffect(((global::alphatab.model.Beat) (dynargs[0]) ));
						break;
					}
					
					
					case 768599606:
					{
						this.readBeatEffects(((global::alphatab.model.Beat) (dynargs[0]) ));
						break;
					}
					
					
					case 379947302:
					{
						this.readChord(((global::alphatab.model.Beat) (dynargs[0]) ));
						break;
					}
					
					
					case 1762376684:
					{
						this.readBeat(((global::alphatab.model.Track) (dynargs[0]) ), ((global::alphatab.model.Bar) (dynargs[1]) ), ((global::alphatab.model.Voice) (dynargs[2]) ));
						break;
					}
					
					
					case 199127676:
					{
						this.readVoice(((global::alphatab.model.Track) (dynargs[0]) ), ((global::alphatab.model.Bar) (dynargs[1]) ));
						break;
					}
					
					
					case 46422045:
					{
						this.readBar(((global::alphatab.model.Track) (dynargs[0]) ));
						break;
					}
					
					
					case 1762181558:
					{
						this.readBars();
						break;
					}
					
					
					case 1728502613:
					{
						this.readTrack();
						break;
					}
					
					
					case 1056509822:
					{
						this.readTracks();
						break;
					}
					
					
					case 316994587:
					{
						this.readMasterBar();
						break;
					}
					
					
					case 1970316280:
					{
						this.readMasterBars();
						break;
					}
					
					
					case 1086991092:
					{
						this.readPlaybackInfos();
						break;
					}
					
					
					case 867499896:
					{
						this.readPageSetup();
						break;
					}
					
					
					case 523068202:
					{
						this.readLyrics();
						break;
					}
					
					
					case 1244852144:
					{
						this.readScoreInformation();
						break;
					}
					
					
					case 1339914850:
					{
						this.readVersion();
						break;
					}
					
					
					default:
					{
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				return default(object);
			}
		}
		
		
		public override   void __hx_getFields(global::haxe.root.Array<object> baseArr){
			unchecked {
				baseArr.push("_playbackInfos");
				baseArr.push("_trackCount");
				baseArr.push("_barCount");
				baseArr.push("_lyricsTrack");
				baseArr.push("_lyrics");
				baseArr.push("_lyricsIndex");
				baseArr.push("_globalTripletFeel");
				baseArr.push("_octave");
				baseArr.push("_keySignature");
				baseArr.push("_tempo");
				baseArr.push("_score");
				baseArr.push("_versionNumber");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


