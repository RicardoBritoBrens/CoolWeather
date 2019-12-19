using Newtonsoft.Json;

namespace CoolWeather.Models.OpenWeatherModels
{
    public class Coord
    {

        [JsonProperty("lon")]
        public double Lon { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }
    }
}



