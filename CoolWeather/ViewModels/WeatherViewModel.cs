using System;
namespace CoolWeather.ViewModels
{
    public class WeatherViewModel
    {

        public int Temp { get; set; }
        public WeatherViewModel()
        {

        }

        public WeatherViewModel(int temp)
        {
            Temp = temp;
        }
    }
}
