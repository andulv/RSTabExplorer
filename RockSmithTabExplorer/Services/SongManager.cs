using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace RockSmithTabExplorer
{
    public class SongManager : INotifyPropertyChanged //SongCollection
    {
        private List<ArcFileWrapper> files = new List<ArcFileWrapper>();
        public string StatusString { get; private set; }

        public IList<RSSongInfo> AvaliableSongInfos { get; private set; }

        public void Add(string file)
        {
            files.Add(new ArcFileWrapper(file));

            if (StatusString.Length>0)
            {
                StatusString = StatusString + ", " + file;
            }
            else
            {
                StatusString = file;
            }
        }

        public void Clear()
        {
            StatusString = "";
            files.Clear();
        }

        /// <summary>
        /// Trigger when all songs have finished loading.
        /// </summary>
        public void FileLoadComplete()
        {
            AvaliableSongInfos = files.SelectMany(f => f.GetAllSongInfos()).ToList();
            OnPropertyChanged("StatusString");
            OnPropertyChanged("AvaliableSongInfos");
        }

        public TrackDetail GetTrackDetail(string songKey, string arrangmentName)
        {
            return files.Select(f=>f.GetTrackDetail(songKey,arrangmentName)).FirstOrDefault(td=>td!=null);
        }

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChangedExplicit(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        protected virtual void OnPropertyChanged(string propertyName)// = null) [CallerMemberName]
        {
            OnPropertyChangedExplicit(propertyName);
        }

        #endregion
    }
}
