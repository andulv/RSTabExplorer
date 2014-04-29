using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.ComponentModel;

namespace RockSmithTabExplorer.ViewModel
{
    public class GuitarPath
    {
        public string Name { get; private set; }

        public GuitarPath(string name)
        {
            Name = name;
        }

        //AvailableSongs.SelectMany(s => s.TrackInfos, (s, t) => t.Name).Distinct().ToList().ForEach(Console.WriteLine);
        //"bass", "combo", "combo2", "vocals", "lead1", "lead2", "rhythm", "combo1", "lead", "rhythm2", "combo3", "rhythm1", "combo4", "bass2", "jvocals"

        public RSTrackInfo pickTrack(IList<RSTrackInfo> songTracks)
        {
            //TODO: change from switch to inheritance. BassPath,RhythmPath,LeadPath and AutoPath.
            switch (Name)
            {
                case "bass":
                    return findTrackContaining(songTracks, new string[] {"bass","combo","rhythm","lead"});
                case "lead":
                    return findTrackContaining(songTracks, new string[] { "lead", "combo", "rhythm", "bass" });
                case "rhythm":
                    return findTrackContaining(songTracks, new string[] { "rhythm", "combo", "lead", "bass" });
                default:
                    throw new InvalidEnumArgumentException("No guitar path");
            }
        }

        private RSTrackInfo findTrackContaining(IList<RSTrackInfo> songTracks, string[] preferences)
        {
            for(int i=0;i<preferences.Length;i++)
            {
                RSTrackInfo found = songTracks.FirstOrDefault(t => t.Name.Contains(preferences[i]));
                if (found != null) return found;
            }
            return songTracks.FirstOrDefault();
        }
    }
}
