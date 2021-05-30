using System;
using System.Globalization;
using Xamarin.Forms;

namespace Definux.Emeraude.MobileSdk.Converters
{
    /// <summary>
    /// Value converter for error message to success flag.
    /// </summary>
    public class ErrorMessageToBoolConverter : IValueConverter
    {
        /// <inheritdoc />
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string errorMessage = (value != null) ? value.ToString() : null;

            return !string.IsNullOrEmpty(errorMessage);
        }

        /// <inheritdoc />
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
