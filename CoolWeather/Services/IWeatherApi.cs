using System.Threading.Tasks;
using CoolWeather.Models.OpenWeatherModels;
using CoolWeather.Models.OpenWeatherModels.ForecastWeather;

namespace CoolWeather.Services
{
    public interface IWeatherApi
    {
        Task<OpenWeatherItem> GetCurrentWeatherItemByCityName(string cityname);
        Task<OpenWeatherItem> GetCurrentWeatherItemByCityNameAndCountryCode(string cityname, int countrycode);
        Task<ForecastWeatherItem> GetHourlyWeatherItemByCityName(string cityname);
        Task<ForecastWeatherItem> GetHourlyWeatherItemByCityNameAndCountryCode(string cityname, int countrycode);
    }
}
