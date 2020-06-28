using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace CoolWeather.Models.OpenWeatherModels.ForecastWeather
{
    public class ForecastWeatherItem
    {
        [JsonProperty("cod")]
        public string Cod { get; set; }

        [JsonProperty("message")]
        public int Message { get; set; }

        [JsonProperty("cnt")]
        public int Cnt { get; set; }

        [JsonProperty("list")]
        public IList<List> List { get; set; }

        [JsonProperty("city")]
        public City City { get; set; }
        public ForecastWeatherItem()
        {
        }
    }

}
