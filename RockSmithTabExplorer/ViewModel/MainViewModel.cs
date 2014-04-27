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
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Input;
using alphatab.model;
using AlphaTab.Wpf.Share.Data;
using AlphaTab.Wpf.Share.Utils;
using System.Linq;
using RocksmithToolkitLib.Xml;
using System.Runtime.CompilerServices;

namespace RockSmithTabExplorer.ViewModel
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
        private readonly RelayCommand _showScoreInfoCommand;

        SongLoader songLoader;
        SongManager songManager = new SongManager();
        public SongManager SongManager
        {
            get { return songManager; }
            private set { songManager = value; }
        }

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
                OnPropertyChanged("Score");
                OnPropertyChangedExplicit("ScoreTitle");
                OnPropertyChangedExplicit("CurrentScoreTrack");
                _showScoreInfoCommand.RaiseCanExecuteChanged();
                TrackToolBarVisible = _score != null;
            }
        }

        public Track CurrentScoreTrack
        {
            get
            {
                if (_score == null || _currentTrackIndex < 0 || _currentTrackIndex >= _score.tracks.length)
                    return null;

                return _score.tracks[_currentTrackIndex] as Track;
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
        public ICommand LoadDiskTracksCommand { get; private set; }
        public ICommand LoadDLCTracksCommand { get; private set; }

        RSSongInfo _selectedRockSmithSong;
        public RSSongInfo SelectedRockSmithSong
        {
            get { return _selectedRockSmithSong; }
            set
            {
                _selectedRockSmithSong = value;
                OnPropertyChanged("SelectedRockSmithSong");

                setTrackFromPath();
            }
        }

        private void OnIsLoadingToggled(object sender, PropertyChangedEventArgs args)
        {
            IsLoading = songLoader.IsLoading;

            // Update SelectedRockSmithSong on song load
            if (args.PropertyName == "IsLoading" && songLoader.IsLoading == false)
            {
                SelectedRockSmithSong = songManager.GetFirstSong();
            }
        }

        //Set from settings at startup, updated from dropdown.
        private string _selectedGuitarPath;
        private GuitarPath guitarPath;
        public string SelectedGuitarPath
        {
            get { return _selectedGuitarPath; }
            set
            {
                _selectedGuitarPath = value;
                RockSmithTabExplorer.Properties.Settings.Default.GuitarPath = value;
                RockSmithTabExplorer.Properties.Settings.Default.Save();
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
                OnPropertyChanged("SelectedRockSmithTrack");
                if (value != null)
                    TrackDetail = songManager.GetTrackDetail(SelectedRockSmithSong.Key, value.Name);
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
                OnPropertyChanged("TrackDetail");
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
                OnPropertyChanged("SelectedLevel");
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
                if (LevelOnlySelected)
                    Score = RockSmithImporter.GetScoreForExactDifficultyLevel(TrackDetail.RockSmithSong, SelectedLevel.Difficulty);
                else
                    Score = RockSmithImporter.GetScoreForMaxDifficultyLevel(TrackDetail.RockSmithSong, SelectedLevel.Difficulty);
            }
            else
                Score = null;
        }

        public string FileNameStatus { get; protected set; }

        bool _levelOnlySelected;
        public bool LevelOnlySelected
        {
            get { return _levelOnlySelected; }
            set
            {
                _levelOnlySelected = value;
                OnPropertyChanged("LevelOnlySelected");
                GenerateScore();
            }
        }

        bool _trackToolBarVisible = false;
        public bool TrackToolBarVisible
        {
            get { return _trackToolBarVisible; }
            private set
            {
                _trackToolBarVisible = value;
                OnPropertyChanged("TrackToolBarVisible");
            }
        }

        bool _isLoading = false;
        public bool IsLoading
        {
            get { return _isLoading; }
            private set
            {
                _isLoading = value;
                OnPropertyChanged("IsLoading");
            }
        }

        #endregion

        public MainViewModel(IDialogService dialogService, IErrorService errorService)
        {
            _dialogService = dialogService;
            _errorService = errorService;
            songLoader = new SongLoader(_dialogService, songManager);

            // Re-raise events for the view
            songManager.PropertyChanged += (sender, args) => this.OnPropertyChanged(args.PropertyName);
            songLoader.PropertyChanged += (sender, args) => this.OnPropertyChanged(args.PropertyName);
            songLoader.PropertyChanged += OnIsLoadingToggled;

            OpenFileCommand = new RelayCommand(songLoader.OpenFile);
            LoadDiskTracksCommand = new RelayCommand(songLoader.LoadDiskTracks);
            LoadDLCTracksCommand = new RelayCommand(songLoader.LoadDLCTracks);
            _showScoreInfoCommand = new RelayCommand(ShowScoreInfo, () => _score != null);

            SelectedGuitarPath = RockSmithTabExplorer.Properties.Settings.Default.GuitarPath;
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
