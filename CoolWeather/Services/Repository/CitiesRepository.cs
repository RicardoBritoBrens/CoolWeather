using System.Collections.Generic;
using System.Collections.ObjectModel;
using CoolWeather.Models.OpenWeatherModels.CityWeather;
using Newtonsoft.Json;
using System.Linq;
using System.Threading.Tasks;
using CoolWeather.Extra;

namespace CoolWeather.Services.Repository
{
    public class CitiesRepository : ICitiesRepository
    {
        public Task<ObservableCollection<CityWeatherItem>> GetAllCities()
        {
            Task<ObservableCollection<CityWeatherItem>> taskResukt = Task.Run(() =>
             {
                 string text = Utils.ReadEmbedddedJsonFile();

                 var localListOfCities = JsonConvert.DeserializeObject<IEnumerable<CityWeatherItem>>(text);

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
