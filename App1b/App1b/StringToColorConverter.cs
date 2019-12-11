using System;
using System.Globalization;
using Xamarin.Forms;

namespace App1b
{
    public class StringToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            ColorTypeConverter cc = new ColorTypeConverter();
            return cc.ConvertFromInvariantString((string)value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((Color)value).ToString();
        }
    }
}
