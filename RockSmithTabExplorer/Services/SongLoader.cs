using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AlphaTab.Wpf.Share.Data;
using System.IO;
using System.ComponentModel;
using System.Windows;

namespace RockSmithTabExplorer
{
    public class SongLoader
    {
        private readonly IDialogService _dialogService;
        private SongCollection songCollection;
        public SongLoader(IDialogService dialogService, SongCollection songCollection)
        {
            _dialogService = dialogService;
            this.songCollection = songCollection;
        }

        private bool isLoading=false;
        public bool IsLoading
        {
            get { return isLoading; }
            private set
            {
                isLoading = value;
                OnPropertyChanged("IsLoading");
            }
        }

        /// <summary>
        /// Opens a new file by loading the file path using the IO service. 
        /// </summary>
        public void OpenFile()
        {
            OpenFile(_dialogService.OpenFile());
        }

        /// <summary>
        /// Opens a new file from the specified file path.
        /// </summary>
        /// <param name="file">the path to the file to load</param>
        public void OpenFile(string file, bool appendSongs = false)
        {
            IsLoading = true;
            BackgroundWorker backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += (s, e) => BackgroundOpenFile(s, e, file, appendSongs);
            backgroundWorker.RunWorkerCompleted += (s, e) => IsLoading = false;
            backgroundWorker.RunWorkerAsync();
        }

        private void BackgroundOpenFile(object sender, DoWorkEventArgs e, string file, bool appendSongs)
        {
            OpenFileWithoutUpdate(file, appendSongs);
        }

        public void OpenFiles(string[] files)
        {
            IsLoading = true;
            BackgroundWorker backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += (s, e) => BackgroundOpenFiles(s, e, files);
            backgroundWorker.RunWorkerCompleted += (s, e) => IsLoading = false;
            backgroundWorker.RunWorkerAsync();
        }

        private void BackgroundOpenFiles(object sender, DoWorkEventArgs e, string[] files)
        {
            foreach (string file in files)
            {
                OpenFileWithoutUpdate(file, true);
            }
        }

        private void OpenFileWithoutUpdate(string file, bool appendSongs = false)
        {
            if (!string.IsNullOrWhiteSpace(file) && File.Exists(file))
            {
                if (!appendSongs)
                {
                    songCollection.Clear();
                }
                songCollection.Add(file);
            }
        }

        public void LoadDiskTracks()
        {
            LoadFromSteam((rocksmithFolder) => OpenFile(rocksmithFolder + @"\songs.psarc"));
        }

        public void LoadDLCTracks()
        {
            LoadFromSteam((rocksmithFolder)=>OpenFiles(Directory.GetFiles(rocksmithFolder + @"\dlc", "*.psarc")));
        }

        private void LoadFromSteam(Action<string> loadAction)
        {
            string rocksmithFolder = RocksmithLocator.Rocksmith2014Folder();
            if (rocksmithFolder != null && rocksmithFolder.Length > 0)
            {
                loadAction(rocksmithFolder);
            }
            else
            {
                MessageBox.Show("Can't find Rocksmith 2014 in Steam Library folders\nTry opening psarc files directly", "Error loading songs", MessageBoxButton.OK, MessageBoxImage.Error);
            }
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
