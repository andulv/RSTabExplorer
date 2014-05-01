using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AlphaTab.Wpf.Share.Data;
using System.IO;
using System.ComponentModel;

namespace RockSmithTabExplorer
{
    public class SongLoader
    {
        private readonly IDialogService _dialogService;
        private SongManager songManager;
        public SongLoader(IDialogService dialogService, SongManager songManager)
        {
            _dialogService = dialogService;
            this.songManager = songManager;
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
            BackgroundWorker backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += (s, e) => BackgroundOpenFile(s, e, file, appendSongs);
            backgroundWorker.RunWorkerCompleted += (s, e) => songManager.FileLoadComplete();
            backgroundWorker.RunWorkerAsync();
        }

        private void BackgroundOpenFile(object sender, DoWorkEventArgs e, string file, bool appendSongs)
        {
            OpenFileWithoutUpdate(file, appendSongs);
        }

        public void OpenFiles(string[] files)
        {
            BackgroundWorker backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += (s, e) => BackgroundOpenFiles(s, e, files);
            backgroundWorker.RunWorkerCompleted += (s, e) => songManager.FileLoadComplete();
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
                    songManager.Clear();
                }
                songManager.Add(file);
            }
        }

        public void LoadDiskTracks()
        {
            string rocksmithFolder = RocksmithLocator.Rocksmith2014Folder();
            if (rocksmithFolder.Length != 0) OpenFile(rocksmithFolder + @"\songs.psarc");
        }

        public void LoadDLCTracks()
        {
            string rocksmithFolder = RocksmithLocator.Rocksmith2014Folder();
            if (rocksmithFolder.Length != 0)
            {
                string[] psarcs = Directory.GetFiles(rocksmithFolder + @"\dlc", "*.psarc");
                OpenFiles(psarcs);
            }
        }
    }
}
