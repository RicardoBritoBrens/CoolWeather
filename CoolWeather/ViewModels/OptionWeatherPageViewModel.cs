using System;
using System.Windows.Input;
using CoolWeather.Services.Navigation;
using CoolWeather.Views;
using Xamarin.Forms;

namespace CoolWeather.ViewModels
{
    public class OptionWeatherPageViewModel : ViewModelBase
    {
        private IPageService _pageService;
        private string _cityImageSource { get; set; }
        private string _curretCitySourceImage { get; set; }

        public string CitiesImageSource
        {
            get => _cityImageSource;
            set
            {
                _cityImageSource = value;
                OnPropertyChanged();
            }
        }
        public string CurretCitySourceImage
        {
            get => _curretCitySourceImage;
            set
            {
                _curretCitySourceImage = value;
                OnPropertyChanged();
            }
        }

        public ICommand CallCurrentLocationPageCommand { get; set; }
        public ICommand CallPickCityPageCommand { get; set; }

        public OptionWeatherPageViewModel(IPageService pageService)
        {
            _pageService = pageService;
            CitiesImageSource = "PickYourCity.jpg";
            CurretCitySourceImage = "CurrentLocation.jpg";
            CallCurrentLocationPageCommand = new Command(CallCurrentLocationPage);
            CallPickCityPageCommand = new Command(CallPickCityPage);
        }
        public void CallCurrentLocationPage()
        {
            _pageService.PushAsync(new MainWeatherPage());
        }
        public void CallPickCityPage()
        {
            _pageService.PushAsync(new StartMainPage());
        }
    }
}
