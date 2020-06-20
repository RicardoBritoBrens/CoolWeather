using System;
using System.Threading.Tasks;
using CoolWeather.Models.OpenWeatherModels;
using CoolWeather.Models.OpenWeatherModels.ForecastWeather;
using Refit;

namespace CoolWeather.Services
{
    public class OpenWeatherApi : IWeatherApi
    {
        /// <summary>
        /// q city name and country code divided by comma, use ISO 3166 country codes
        /// Sample: api.openweathermap.org/data/2.5/weather?q={city name}
        /// Sample: api.openweathermap.org/data/2.5/weather?q={city name},{country code}
        /// </summary>
        [Get("/data/2.5/weather?q={cityname}&APPID=2ea0f55a684ffc85aafee4ce127480fd")]
        public Task<OpenWeatherItem> GetCurrentWeatherItemByCityName(string cityname)
        {
            throw new NotImplementedException();
        }
        [Get("/data/2.5/weather?q={cityname},{countrycode}&APPID=2ea0f55a684ffc85aafee4ce127480fd")]
        public Task<OpenWeatherItem> GetCurrentWeatherItemByCityNameAndCountryCode(string cityname, int countrycode)
        {
            throw new NotImplementedException();
        }
        [Get("/data/2.5/forecast?q={cityname}&appid=2ea0f55a684ffc85aafee4ce127480fd")]
        public Task<ForecastWeatherItem> GetHourlyWeatherItemByCityName(string cityname)
        {
            throw new NotImplementedException();
        }
        [Get("/data/2.5/forecast?q={cityname},{countrycode}&appid=2ea0f55a684ffc85aafee4ce127480fd")]
        public Task<ForecastWeatherItem> GetHourlyWeatherItemByCityNameAndCountryCode(string cityname, int countrycode)
        {
            throw new NotImplementedException();
        }
    }
}
