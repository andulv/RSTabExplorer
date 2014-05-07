using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AlphaTab.Platform.CSharp.Wpf;
using System.Windows;

namespace RockSmithTabExplorer.Controls
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
                {
                    Settings.Staves.ToArray().First(s => s.Id == "score_disabled").Id = "score";
                    Settings.Staves.ToArray().First(s => s.Id == "marker_disabled").Id = "marker";
                }
                else
                {
                    Settings.Staves.ToArray().First(s => s.Id == "score").Id = "score_disabled";
                    Settings.Staves.ToArray().First(s => s.Id == "marker").Id = "marker_disabled";
                }
            }
        }


        public void EnableZoomMode()
        {
            ShowScore = false;

            setLayoutSettings((layoutSettings) =>
            {
                layoutSettings["spacingScale"] = 0.6f;
            });

            //Settings.Staves.Add(new AlphaTab.StaveSettings("rhythm-up"));
        }

        public void DisableZoomMode()
        {
            ShowScore = true;

            setLayoutSettings((layoutSettings)=>
            {
                layoutSettings["spacingScale"] = 1.0f;
            });
        }

        private void setLayoutSettings(Action<AlphaTab.Collections.FastDictionary<string, object>> action)
        {
            var layoutSettings = new AlphaTab.Collections.FastDictionary<string, object>();
            action(layoutSettings);
            Settings.Layout.AdditionalSettings = layoutSettings;
        }

    }
}
