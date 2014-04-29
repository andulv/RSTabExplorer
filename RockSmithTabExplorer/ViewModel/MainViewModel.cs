/*
 * This file is part of alphaTab.
 * Copyright c 2013, Daniel Kuschny and Contributors, All rights reserved.
 * 
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 3.0 of the License, or at your option any later version.
 * 
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Lesser General Public License for more details.
 * 
 * You should have received a copy of the GNU Lesser General Public
 * License along with this library.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using alphatab.importer;
using alphatab.model;
using AlphaTab.Wpf.Share.Data;
using AlphaTab.Wpf.Share.Utils;
using AlphaTab.src.alphatab.importer;
using System.Linq;
using System.Xml.Linq;
using RocksmithToolkitLib.Xml;
using System.Windows;
using RockSmithTabExplorer;
using RockSmithTabExplorer.ViewModel;

namespace AlphaTab.Wpf.Share.ViewModel
{
    /// <summary>
    /// This viewmodel contains the data and logic for the main application window. 
    /// </summary>
    public class MainViewModel : INotifyPropertyChanged
    {
        // references to the services we want to use
        private readonly IDialogService _dialogService;
        private readonly IErrorService _errorService;
        #region Score Data

        // those properties store the score information
        private Score _score;
        private int _currentTrackIndex;
        ArcFileWrapper _archiveFile;
        private readonly RelayCommand _showScoreInfoCommand;

        public Score Score
        {
            get { return _score; }
            protected set
            {
                _score = value;
                if (value != null && _score.tracks.length > 0)
                    _currentTrackIndex = 0;
                else
                    _currentTrackIndex = -1;
                OnPropertyChanged();
                OnPropertyChangedExplicit("ScoreTitle");
                OnPropertyChangedExplicit("CurrentScoreTrack");
                _showScoreInfoCommand.RaiseCanExecuteChanged();
            }
        }

        public Track CurrentScoreTrack 
        { 
            get 
            {
                if (_score == null || _currentTrackIndex < 0 || _currentTrackIndex >= _score.tracks.length)
                    return null;

                return  _score.tracks[_currentTrackIndex] as Track; 
            } 
        }

        public string ScoreTitle
        {
            get
            {
                return _score == null ? "No File Opened" : _score.title;
            }
        }


        public ICommand ShowScoreInfoCommand { get { return _showScoreInfoCommand; } }
        public void ShowScoreInfo()
        {
            if (_score != null)
                _dialogService.ShowScoreInfo(_score);
        }

        #endregion

        #region Score Loading

        public ICommand OpenFileCommand { get; private set; }

        /// <summary>
        /// Opens a new file by loading the file path using the IO service. 
        /// </summary>
        public void OpenFile()
        {
            //InternalOpenRockSmithFile(@"d:\Program Files (x86)\Rocksmith 2014\songs.psarc");
            //InternalOpenRockSmithFile(@"d:\Rocksmith\Metallica - Nothing Else Matters_p.psarc");

            //var package=new RSPackageInfo(){FileName=@"d:\Program Files (x86)\Rocksmith 2014\songs.psarc"};
            //ArchiveUtils.ExtractPackage(package, @"d:\Program Files (x86)\Extracted\");
            OpenFile(_dialogService.OpenFile());
            //InternalOpenRockSmithFile(@"d:\Program Files (x86)\Joy Division - Dead Souls_p_Pc\songs\bin\generic\deadsoulsjd_bass.xml");           
            //InternalOpenRockSmithFile(@"d:\Program Files (x86)\Smells Like Teen Spirit_p_Pc\songs\bin\generic\smellsliketeenspirit_bass.xml");
            //InternalOpenRockSmithFile(@"d:\Program Files (x86)\Metallica - Nothing Else Matters_p_Pc\songs\bin\generic\nothingelsematters_bass.xml");
            //InternalOpenFile(@"E:\Tablature\Test tittel.gp5");
        }

        /// <summary>
        /// Opens a new file from the specified file path.
        /// </summary>
        /// <param name="file">the path to the file to load</param>
        private void OpenFile(string file)
        {
            if (!string.IsNullOrWhiteSpace(file) && File.Exists(file))
            {
                InternalOpenRockSmithFile(file);
            }
        }

        protected void InternalOpenRockSmithFile(string file)
        {
            FileName = file;
            _archiveFile = new ArcFileWrapper(file);
            AvailableSongs = _archiveFile.GetAllSongInfos();
            OnPropertyChanged("FileName");
            OnPropertyChanged("AvailableSongs");

            SelectedRockSmithSong = AvailableSongs.FirstOrDefault();
        }


        //Is set when file is opened (root of all things)
        public IList<RSSongInfo> AvailableSongs { get; protected set; }

        //Is set by user by selecting in listview. Automtically set when AvailableSongs is set.
        RSSongInfo _selectedRockSmithSong;
        public RSSongInfo SelectedRockSmithSong
        {
            get { return _selectedRockSmithSong; }
            set
            {
                _selectedRockSmithSong = value;
                OnPropertyChanged();

                setTrackFromPath();
            }
        }


        private string _selectedGuitarPath;
        private GuitarPath guitarPath;
        public string SelectedGuitarPath
        {
            get { return _selectedGuitarPath; }
            set
            {
                _selectedGuitarPath = value;
                guitarPath = new GuitarPath(value);
                OnPropertyChanged("SelectedGuitarPath");
                setTrackFromPath();
            }
        }

        private void setTrackFromPath()
        {
            if (SelectedRockSmithSong != null && SelectedRockSmithSong.TrackInfos != null)
                SelectedRockSmithTrack = guitarPath.pickTrack(SelectedRockSmithSong.TrackInfos);
        }

        //Is set by user by selecting in dropdown. Automtically set when SelectedRockSmithSong is set.
        RSTrackInfo _selectedRockSmithTrack;
        public RSTrackInfo SelectedRockSmithTrack
        {
            get { return _selectedRockSmithTrack; }
            set
            {
                _selectedRockSmithTrack = value;
                OnPropertyChanged();
                if (value != null)
                    TrackDetail = _archiveFile.GetTrackDetail(SelectedRockSmithSong.Key, value.Name);
                else
                    TrackDetail = null;
            }
        }

        //Is set when SelectedRockSmithTrack changes. Acts as source for level-dropdown
        TrackDetail _trackDetail;
        public TrackDetail TrackDetail
        {
            get { return _trackDetail; }
            protected set
            {
                _trackDetail = value;
                OnPropertyChanged();
                if (_trackDetail != null && _trackDetail.RockSmithSong != null && _trackDetail.RockSmithSong.Levels != null)
                    SelectedLevel = _trackDetail.RockSmithSong.Levels.LastOrDefault();
                else
                    SelectedLevel = null;
            }
        }

        //Is set by user by selecting in dropdown. Automtically set when TrackDetail is set.
        SongLevel2014 _selectedLevel;
        public SongLevel2014 SelectedLevel
        {
            get { return _selectedLevel; }
            set
            {
                _selectedLevel = value;
                OnPropertyChanged();
                GenerateScore();
            }
        }

        private void GenerateScore()
        {
            if (TrackDetail != null && SelectedLevel != null)
            {
                //using(var stream=File.OpenWrite(@"d:\rocksmith\temp\" + TrackDetail.RockSmithSong.Title + "_" + TrackDetail.RockSmithSong.Arrangement + ".xml"))
                //{
                //    TrackDetail.RockSmithSong.Serialize(stream);
                //}
                if(LevelOnlySelected)
                    Score = RockSmithImporter.GetScoreForExactDifficultyLevel(TrackDetail.RockSmithSong, SelectedLevel.Difficulty);
                else
                    Score = RockSmithImporter.GetScoreForMaxDifficultyLevel(TrackDetail.RockSmithSong, SelectedLevel.Difficulty);
            }
            else
                Score = null;
        }

        public string FileName { get; protected set; }

        bool _levelOnlySelected;
        public bool LevelOnlySelected
        {
            get { return _levelOnlySelected; }
            set
            {
                _levelOnlySelected = value;
                OnPropertyChanged();
                GenerateScore();
            }
        }



        #endregion

        public MainViewModel(IDialogService dialogService, IErrorService errorService)
        {
            _dialogService = dialogService;
            _errorService = errorService;
            OpenFileCommand = new RelayCommand(OpenFile);
            _showScoreInfoCommand = new RelayCommand(ShowScoreInfo, () => _score != null);

            string rocksmithFolder = RocksmithLocator.Rocksmith2014Folder();
            if (rocksmithFolder.Length != 0) OpenFile(rocksmithFolder + @"\songs.psarc");
        }


        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChangedExplicit(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            OnPropertyChangedExplicit(propertyName);
        }

        #endregion
    }
}
