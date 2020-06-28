using Newtonsoft.Json;

namespace CoolWeather.Models.OpenWeatherModels.ForecastWeather
{
    public class Coord
    {
        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lon")]
        public double Lon { get; set; }
    }
}
