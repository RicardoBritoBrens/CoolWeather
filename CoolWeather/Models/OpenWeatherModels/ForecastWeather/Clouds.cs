using Newtonsoft.Json;

namespace CoolWeather.Models.OpenWeatherModels.ForecastWeather
{
    public class Clouds
    {
        [JsonProperty("all")]
        public int All { get; set; }
    }
}
