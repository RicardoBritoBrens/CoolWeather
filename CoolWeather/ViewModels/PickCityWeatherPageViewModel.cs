using System.ComponentModel;
using CoolWeather.Services.Navigation;

namespace CoolWeather.ViewModels
{
    public class PickCityWeatherPageViewModel : INotifyPropertyChanged
    {
        private IPageService _pageService;

        public event PropertyChangedEventHandler PropertyChanged;

        public int Temp { get; set; }

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
