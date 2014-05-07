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
    /// <summary>
    /// Interaction logic for InfoTabs.xaml
    /// </summary>
    public partial class InfoTabs : UserControl
    {
        public InfoTabs()
        {
            InitializeComponent();
        }

        void ChordTemplateFilter(object sender, System.Windows.Data.FilterEventArgs e)
        {
            var chordTemplate = e.Item as RocksmithToolkitLib.Xml.SongChordTemplate2014;
            e.Accepted = chordTemplate.ChordId == null ? false : true;
        }
    }
}
