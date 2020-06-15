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

            //MainPage = new NavigationPage(new StartMainPage());

            // TODO: FIND A WAY TO SHOW A ACTIVITY INDICATOR WAY IS LOADING
            // TODO: ADD PROPER FORMAT FOR THE PRINCIPAL LIST OF CITIES
            // TODO: Add all additional classes and interfaces to handle in the right way http request to the OpenWeather API
            // TODO: Complete the Look and feel of the MainWeatherPage
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
