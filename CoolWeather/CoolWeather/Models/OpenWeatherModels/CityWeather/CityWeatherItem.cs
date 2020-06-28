using System;
using Newtonsoft.Json;

namespace CoolWeather.Models.OpenWeatherModels.CityWeather
{
    public class CityWeatherItem
    {        
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("coord")]
        public Coord Coord { get; set; }
    }
}
