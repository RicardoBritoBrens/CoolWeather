using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CoolWeather.Models.OpenWeatherModels.CityWeather;
using CoolWeather.Views;

namespace CoolWeather.ViewModels
{
    public class WeatherViewModel: ViewModelBase
    {

        public ObservableCollection<CityWeatherItem> Cities { get; set; }
        

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
