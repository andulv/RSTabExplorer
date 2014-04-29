using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AlphaTab.src.alphatab.importer;
using System.Text.RegularExpressions;

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
            return songTracks.FirstOrDefault(t=> t.Name.Contains("bass")) ?? songTracks.FirstOrDefault();
        }
    }
}
