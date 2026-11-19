using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace syncfusion.pdfviewerdemos.wpf
{
    public class PropertyToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string propertyName)
            {
                if (propertyName == "Andrew Fuller")
                {
                    return new SolidColorBrush( Colors.Red);
                }
                else
                {
                    return new SolidColorBrush(Colors.Green);
                }
            }
            return Colors.Transparent;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
