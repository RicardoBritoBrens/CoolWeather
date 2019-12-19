using System;
using System.Collections.ObjectModel;
using CoolWeather.Models.OpenWeatherModels.CityWeather;

namespace CoolWeather.Services
{
    public interface ICitiesRepository
    {
        ObservableCollection<CityWeatherItem> GetAllCities();
    }
}
