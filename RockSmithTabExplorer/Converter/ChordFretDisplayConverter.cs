using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Windows.Data;

namespace RockSmithTabExplorer
{
    public class ChordFretDisplayConverter : IValueConverter
    {
        public object Convert(object o, Type type, object parameter, CultureInfo culture)
        {
            SByte fret = (SByte)o;
            if (fret == -1) return "x";
            return fret.ToString();
            
        }
        public object ConvertBack(object o, Type type, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
