using System;
using System.Threading.Tasks;
using Refit;

namespace CoolWeather.Services
{
    public interface IOpenWeatherApi
    {
        /// <summary>
        /// q city name and country code divided by comma, use ISO 3166 country codes
        /// Sample: api.openweathermap.org/data/2.5/weather?q={city name}
        /// Sample: api.openweathermap.org/data/2.5/weather?q={city name},{country code}
        /// </summary>
        /// <returns></returns>
        [Get("/data/2.5/weather?q={cityname}&APPID=2ea0f55a684ffc85aafee4ce127480fd")]
        Task<string> GetWeatherByCityName(string cityname);

        [Get("/data/2.5/weather?q={cityname},{countrycode}&APPID=2ea0f55a684ffc85aafee4ce127480fd")]
        Task<string> GetWeatherByCityNameAndCountryCode(string cityname, int countrycode);

    }
}
