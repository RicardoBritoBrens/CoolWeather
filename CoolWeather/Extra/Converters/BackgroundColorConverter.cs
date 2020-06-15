using System;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoolWeather.Extra.Converters
{
    public class BackgroundColorConverter : IMarkupExtension, IValueConverter
    {
        public bool IsStart { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is int temp)
            {

                var resources = Application.Current.Resources;

                if (temp > 60)
                {
                    // Warm
                    return IsStart ? resources["WarmStartColor"] : resources["WarmEndColor"];
                }
                else if (temp == -100)
                {
                    // Night
                    return IsStart ? resources["NightStartColor"] : resources["NightEndColor"];
                }
                else
                {
                    // Cold
                    return IsStart ? resources["ColdStartColor"] : resources["ColdEndColor"];
                }
            }
            return Color.Black;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}
