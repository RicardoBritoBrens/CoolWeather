using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using CoolWeather.Models.OpenWeatherModels.CityWeather;

namespace CoolWeather.Services.Repository
{
    public interface ICitiesRepository
    {
        Task<ObservableCollection<CityWeatherItem>> GetAllCities();
    }
}
