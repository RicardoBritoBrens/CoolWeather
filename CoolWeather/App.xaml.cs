using Xamarin.Forms;
using CoolWeather.Views;
namespace CoolWeather
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainWeatherPage());

            // TODO: SHOW A ACTIVITY INDICATOR WHILE IS LOADING (PickCityWeatherPage)
            // TODO: IMPROVE FORMAT FOR THE PRINCIPAL LIST OF CITIES (PickWeatherPage)
            // TODO: Centralize Elements (MainWeatherPage)
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
