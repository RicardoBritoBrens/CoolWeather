using Xamarin.Forms;
using CoolWeather.Views;
namespace CoolWeather
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new NavigationPage(new MainWeatherPage());
            MainPage = new NavigationPage(new OptionWeatherPage());
            // MainPage = new NavigationPage(new StartMainPage());


            // TODO: Rename Views as follow
            /*  1- MainWeatherPage,
                2- PickCityWeatherPage,
                3- CurrentWeatherPage
            */
            // TODO: SHOW A ACTIVITY INDICATOR WAY IS LOADING (PickCityWeatherPage)
            // TODO: IMPROVE FORMAT FOR THE PRINCIPAL LIST OF CITIES (PickWeatherPage)
            // TODO: Centralize Elements (MainWeatherPage)
            // TODO: Centralize Animation (SplashScreenPage)
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
