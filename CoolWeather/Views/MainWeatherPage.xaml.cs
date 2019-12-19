using System.Threading.Tasks;
using CoolWeather.Services;
using Refit;
using Xamarin.Forms;

namespace CoolWeather.Views
{
    public partial class MainWeatherPage : ContentPage
    {
        public MainWeatherPage()
        {
            InitializeComponent();
            // TODO: Add all additional classes and interfaces to handle in the right way http request to the OpenWeather API
            // TODO: Complete the Look and feel of the MainWeatherPage
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await CallApi();
        }

        async Task CallApi()
        {
            //var apiResponse = RestService.For<IOpenWeatherApi>("https://api.openweathermap.org");

            //var testWeather = await apiResponse.GetCurrentWeatherItemByCityName("London");                                                           

            var apiResponse = RestService.For<IOpenWeatherApi>("https://api.openweathermap.org");

            var testWeather = await apiResponse.GetHourlyWeatherItemByCityName("Dominican Republic");

            
        }
    }
}
