using Newtonsoft.Json;

namespace CoolWeather.Models.OpenWeatherModels.ForecastWeather
{
    public class Sys
    {

        [JsonProperty("pod")]
        public string Pod { get; set; }
    }
}
