using System.Threading.Tasks;
using CoolWeather.Models.OpenWeatherModels;
using CoolWeather.Models.OpenWeatherModels.ForecastWeather;
using Refit;

namespace CoolWeather.Services
{
    public interface IWeatherApi
    {
        [Get("/data/2.5/weather?q={cityname}&APPID=2ea0f55a684ffc85aafee4ce127480fd")]
        Task<OpenWeatherItem> GetCurrentWeatherItemByCityName(string cityname);
        [Get("/data/2.5/weather?q={cityname},{countrycode}&APPID=2ea0f55a684ffc85aafee4ce127480fd")]
        Task<OpenWeatherItem> GetCurrentWeatherItemByCityNameAndCountryCode(string cityname, int countrycode);
        [Get("/data/2.5/forecast?q={cityname}&appid=2ea0f55a684ffc85aafee4ce127480fd")]
        Task<ForecastWeatherItem> GetHourlyWeatherItemByCityName(string cityname);
        [Get("/data/2.5/forecast?q={cityname},{countrycode}&appid=2ea0f55a684ffc85aafee4ce127480fd")]
        Task<ForecastWeatherItem> GetHourlyWeatherItemByCityNameAndCountryCode(string cityname, int countrycode);
    }
}
