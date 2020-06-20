using System;
using System.Threading.Tasks;
using CoolWeather.Services;
using CoolWeather.Services.Navigation;
using CoolWeather.ViewModels;
using Refit;
using Xamarin.Forms;

namespace CoolWeather.Views
{
    public partial class PickCityWeatherPage : ContentPage
    {
        public PickCityWeatherPage()
        {
            InitializeComponent();

            var pageService = new PageService();
            ViewModel = new PickCityWeatherPageViewModel(pageService);
        }

        public PickCityWeatherPageViewModel ViewModel
        {
            get => BindingContext as PickCityWeatherPageViewModel;
            set
            {
                BindingContext = value;
            }
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await CallApi();
        }

        async Task CallApi()
        {
            // TODO: IMPROVE CALL API USING REFI
            //var apiResponse = RestService.For<IOpenWeatherApi>("https://api.openweathermap.org");
            //var testWeather = await apiResponse.GetCurrentWeatherItemByCityName("London");                                                           
            var apiResponse = RestService.For<IWeatherApi>("https://api.openweathermap.org");
            var testWeather = await apiResponse.GetHourlyWeatherItemByCityName("Dominican Republic");
        }
    }
}
