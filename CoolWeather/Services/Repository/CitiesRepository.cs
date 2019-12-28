using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using CoolWeather.Models.OpenWeatherModels.CityWeather;
using Newtonsoft.Json;
using System.Linq;
using System.Threading.Tasks;

namespace CoolWeather.Services.Repository
{
    public class CitiesRepository: ICitiesRepository
    {
        private const string ResourceIdEmbeddedJSONFile = "CoolWeather.ExtraFiles.city_list.json";
        public CitiesRepository()
        {
        }

        public Task<ObservableCollection<CityWeatherItem>> GetAllCities()
        {
            Task<ObservableCollection<CityWeatherItem>> taskResukt;

            taskResukt = Task.Run(() =>
            {

                Assembly assembly = Assembly.GetExecutingAssembly();

                Stream stream = assembly.GetManifestResourceStream(ResourceIdEmbeddedJSONFile);

                string text = string.Empty;

                using (var reader = new StreamReader(stream))
                {
                    text = reader.ReadToEnd();
                }

                IEnumerable<CityWeatherItem> localListOfCities = JsonConvert.DeserializeObject<IEnumerable<CityWeatherItem>>(text);

                return
                    new ObservableCollection<CityWeatherItem>(
                        localListOfCities
                    .OrderBy(x => x.Name)
                    .Where(x => !x.Name.Contains(".") && !x.Name.Contains("-") && !string.IsNullOrWhiteSpace(x.Name)));
            });

            return taskResukt;
        }
    }
} 
