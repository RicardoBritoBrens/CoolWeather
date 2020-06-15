using CoolWeather.Services.Navigation;

namespace CoolWeather.ViewModels
{
    public class MainWeatherViewModel : ViewModelBase
    {
        public int Temp
        {
            get => _temp;
            set
            {
                _temp = value;
                OnPropertyChanged();
            }
        }
        public int _temp { get; set; }
        public MainWeatherViewModel(int temp)
        {
            Temp = temp;
        }
        private IPageService _pageService;
        public MainWeatherViewModel()
        {

        }
        public MainWeatherViewModel(IPageService pageService)
        {
            _pageService = pageService;
        }


    }
}
