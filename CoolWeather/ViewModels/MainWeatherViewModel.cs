using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CoolWeather.Models.OpenWeatherModels.CityWeather;
using CoolWeather.Views;

namespace CoolWeather.ViewModels
{
    public class MainWeatherViewModel: ViewModelBase
    {        
        public int Temp
        {
            get => _temp;
            set
            {
                _temp = value;
                OnPropertyChanged();
            }
        }
        public int _temp { get; set; }
        public MainWeatherViewModel()
        {

        }

        public MainWeatherViewModel(int temp)
        {
            Temp = temp;
        }
    }
}
