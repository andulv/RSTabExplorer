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
using System.Windows;
using AlphaTab.Wpf.Share.Data;
using RockSmithTabExplorer.ViewModel;
using System.Reflection;

namespace AlphaTab.Wpf.Gdi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Title = this.Title + " - v" + Assembly.GetEntryAssembly().GetName().Version.ToString();
        }

        private void OnRenderFinished(object sender, RoutedEventArgs e)
        {
            // setup the size of the background and the shadow
            TablatureContainer.Width = TablatureControl.Width;
            TablatureContainer.Height = TablatureControl.Height;
            TablatureShadow.Width = TablatureControl.Width;
            TablatureShadow.Height = TablatureControl.Height;
        }
    }
}
