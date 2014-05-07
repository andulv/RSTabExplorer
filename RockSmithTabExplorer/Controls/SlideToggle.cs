using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RockSmithTabExplorer.Controls
{
    public class SlideToggle : CheckBox
    {
        static SlideToggle()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SlideToggle), new FrameworkPropertyMetadata(typeof(SlideToggle)));
        }

        public object On
        {
            get { return GetValue(OnProperty); }
            set { SetValue(OnProperty, value); }
        }

        public static readonly DependencyProperty OnProperty =
            DependencyProperty.Register("On", typeof(object), typeof(SlideToggle), null);

        public object Off
        {
            get { return GetValue(OffProperty); }
            set { SetValue(OffProperty, value); }
        }

        public static readonly DependencyProperty OffProperty =
            DependencyProperty.Register("Off", typeof(object), typeof(SlideToggle), null);
    }
}
