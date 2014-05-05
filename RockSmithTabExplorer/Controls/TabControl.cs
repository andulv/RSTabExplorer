using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AlphaTab.Platform.CSharp.Wpf;
using System.Windows;

namespace RockSmithTabExplorer
{
    public class TabControl : AlphaTabImage
    {
        public static DependencyProperty ZoomEnabledProperty =
            DependencyProperty.Register("ZoomEnabled", typeof(bool), typeof(TabControl), new PropertyMetadata(false, OnZoomModeChanged));

        public TabControl() : base()
        {
        }

        public bool ZoomEnabled
        {
            get { return (bool)GetValue(ZoomEnabledProperty); }
            set { SetValue(ZoomEnabledProperty, value); }
        }

        private static void OnZoomModeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var tab = (TabControl)d;
            if ((bool)e.NewValue)
            {
                tab.EnableZoomMode();
            }
            else
            {
                tab.DisableZoomMode();
            }

            tab.InvalidateTrack();
        }

        private bool showScore = true;
        private bool ShowScore
        {
            get { return showScore; }
            set
            {
                if (showScore == value)
                    return;
                showScore = value;
                if (value)
                    Settings.Staves.Add(new AlphaTab.StaveSettings("score"));
                else
                    Settings.Staves.RemoveAt(Settings.Staves.FindIndex(s => s.Id == "score"));
            }
        }


        public void EnableZoomMode()
        {
            ShowScore = false;
            Settings.Scale = 0.9f;
            //Settings.Width = 1300;//950;

            // Layout Settings
            var layoutSettings = new AlphaTab.Collections.FastDictionary<string, object>();
            //layoutSettings["autoSize"] = false;
            layoutSettings["barsPerRow"] = 4;
            Settings.Layout.AdditionalSettings = layoutSettings;

            //Settings.Staves.Add(new StaveSettings("rhythm-up"));
        }

        public void DisableZoomMode()
        {
            ShowScore = true;
            Settings.Scale = 1f;
            Settings.Layout.AdditionalSettings = new AlphaTab.Collections.FastDictionary<string, object>();
        }

    }
}
