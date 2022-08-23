using System;
using System.Globalization;
using System.Windows.Data;

namespace MvvmSample.Converters
{
    public class DateConterver : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            DateTime date = (DateTime)value;
            date = DateTime.Today;

            return date.ToString("dd/MMM/yyyy ");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
