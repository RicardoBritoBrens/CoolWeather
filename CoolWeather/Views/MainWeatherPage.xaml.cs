using System.Threading.Tasks;
using CoolWeather.Services;
using CoolWeather.ViewModels;
using Refit;
using Xamarin.Forms;

namespace CoolWeather.Views
{
    public partial class MainWeatherPage : ContentPage
    {
        public MainWeatherPage()
        {
            InitializeComponent();

            /*
             * 
            var pageService = new PageService();
            ViewModel = new MainWeatherViewModel(pageService);
            */


        }

        public OptionWeatherPageViewModel ViewModel
        {
            get => (BindingContext as OptionWeatherPageViewModel);
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
            //var apiResponse = RestService.For<IOpenWeatherApi>("https://api.openweathermap.org");

            //var testWeather = await apiResponse.GetCurrentWeatherItemByCityName("London");                                                           

            var apiResponse = RestService.For<IOpenWeatherApi>("https://api.openweathermap.org");

            var testWeather = await apiResponse.GetHourlyWeatherItemByCityName("Dominican Republic");

            
        }
    }
}
