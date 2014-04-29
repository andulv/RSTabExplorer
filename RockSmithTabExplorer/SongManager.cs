using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RockSmithTabExplorer
{
    public class SongManager
    {
        private List<ArcFileWrapper> files = new List<ArcFileWrapper>();

        public void Add(string file)
        {
            Add(new ArcFileWrapper(file));
        }
        public void Add(ArcFileWrapper arcFile)
        {
            files.Add(arcFile);
        }

        public IList<RSSongInfo> GetAllSongInfos()
        {
            return files.SelectMany(f => f.GetAllSongInfos()).ToList();
        }

        public TrackDetail GetTrackDetail(string songKey, string arrangmentName)
        {
            return files.Select(f=>f.GetTrackDetail(songKey,arrangmentName)).FirstOrDefault(td=>td!=null);
        }

    }
}
