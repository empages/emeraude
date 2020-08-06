using System;
using System.Globalization;
using Xamarin.Forms;

namespace Definux.Emeraude.MobileSdk.Converters
{
    public class ErrorMessageToBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string errorMessage = (value != null) ? value.ToString() : null;

            return !string.IsNullOrEmpty(errorMessage);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
