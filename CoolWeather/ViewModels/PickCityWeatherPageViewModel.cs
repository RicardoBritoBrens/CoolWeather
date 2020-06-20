using CoolWeather.Services.Navigation;

namespace CoolWeather.ViewModels
{
    public class PickCityWeatherPageViewModel : ViewModelBase
    {
        private IPageService _pageService;
        public int Temp
        {
            get => _temp;
            set
            {
                _temp = value;
                OnPropertyChanged();
            }
        }
        private int _temp { get; set; }

        public PickCityWeatherPageViewModel()
        {

        }
        public PickCityWeatherPageViewModel(int temp)
        {
            Temp = temp;
        }
        public PickCityWeatherPageViewModel(IPageService pageService)
        {
            _pageService = pageService;
        }

    }

}
