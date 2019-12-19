using Newtonsoft.Json;

namespace CoolWeather.Models.OpenWeatherModels.ForecastWeather
{
    public class Rain
    {
        [JsonProperty("3h")]
        public double Value { get; set; }
    }
}
