using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using CoolWeather.Models.OpenWeatherModels.CityWeather;
using CoolWeather.Services.Navigation;
using CoolWeather.Services.Repository;
using Xamarin.Forms;

namespace CoolWeather.ViewModels
{
    public class StartMainPageViewModel : ViewModelBase
    {

        private IPageService _pageService;
        private ICitiesRepository _citiesRepository;
        private bool _enableActivity { get; set; }

        public ICommand GetCitiesCommand { get; set; }
        public bool EnableActivity
        {
            get => _enableActivity;
            set
            {
                _enableActivity = value;
                OnPropertyChanged();
            }
        }
        private ObservableCollection<CityWeatherItem> _cities { get; set; }
        public ObservableCollection<CityWeatherItem> Cities
        {
            get => _cities;
            set
            {
                _cities = value;
                OnPropertyChanged();
                if (_cities.Count < 0)
                {
                    IsBusy = true;
                }
            }
        }
        public StartMainPageViewModel(IPageService pageService)
        {
            _pageService = pageService;
            _citiesRepository = new CitiesRepository();
            Cities = new ObservableCollection<CityWeatherItem>();
            GetCitiesCommand = new Command(async () => await GetCities());
            IsBusy = true;
            EnableActivity = false;
        }

        private async Task GetCities()
        {
            IsBusy = true;
            Cities = await _citiesRepository.GetAllCities();

            if (Cities.Count > 0)
            {
                IsBusy = false;
                await _pageService.DisplayAlert("Información", "Ciudades Cargadas Correctamente", "OK");
            }
            else
            {
                await _pageService.DisplayAlert("Advertencia", "Ciudades no fueron cargadas", "OK");
            }
            return;
        }
    }
}
