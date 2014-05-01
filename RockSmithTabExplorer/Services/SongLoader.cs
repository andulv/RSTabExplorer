using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AlphaTab.Wpf.Share.Data;
using System.IO;

namespace RockSmithTabExplorer
{
    public class SongLoader
    {
        private readonly IDialogService _dialogService;
        private SongManager songManager;
        public SongLoader(IDialogService dialogService, SongManager songCollection)
        {
            _dialogService = dialogService;
            songManager = songCollection;
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
            OpenFileWithoutUpdate(file, appendSongs);
            PostFileOpenUpdate();
        }

        public void OpenFiles(string[] files)
        {
            foreach (string file in files)
            {
                OpenFileWithoutUpdate(file, true);
            }
            PostFileOpenUpdate();
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

        private void PostFileOpenUpdate()
        {
            songManager.FileLoadComplete();
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
