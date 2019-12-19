using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using CoolWeather.Models.OpenWeatherModels.CityWeather;
using Newtonsoft.Json;

namespace CoolWeather.Services.Repository
{
    public class CitiesRepository: ICitiesRepository
    {
        private const string ResourceIdEmbeddedJSONFile = "CoolWeather.ExtraFiles.city_list.json";
        public CitiesRepository()
        {
        }

        public ObservableCollection<CityWeatherItem> GetAllCities()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            Stream stream = assembly.GetManifestResourceStream(ResourceIdEmbeddedJSONFile);

            string text = string.Empty;

            using (var reader = new StreamReader(stream))
            {
                text = reader.ReadToEnd();
            }

            IEnumerable<CityWeatherItem> localListOfCities = JsonConvert.DeserializeObject<IEnumerable<CityWeatherItem>>(text);

            return new ObservableCollection<CityWeatherItem>(localListOfCities);
        }
    }
}
