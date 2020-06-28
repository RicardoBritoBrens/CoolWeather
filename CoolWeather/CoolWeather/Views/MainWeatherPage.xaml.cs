using System;
using CoolWeather.Services.Navigation;
using CoolWeather.ViewModels;
using Xamarin.Forms;

namespace CoolWeather.Views
{
    public partial class MainWeatherPage : ContentPage
    {
        public MainWeatherPage()
        {
            InitializeComponent();

            var pageService = new PageService();
            ViewModel = new MainWeatherViewModel(pageService);

        }

        public MainWeatherViewModel ViewModel
        {
            get => (BindingContext as MainWeatherViewModel);
            set
            {
                BindingContext = value;
            }
        }

        public void CurrentLocationTapped(System.Object sender, System.EventArgs e)
        {
            (BindingContext as MainWeatherViewModel).CallCurrentLocationPageCommand.Execute(null);
        }

        public void PickCityElementTapped(System.Object sender, System.EventArgs e)
        {
            (BindingContext as MainWeatherViewModel).CallPickCityPageCommand.Execute(null);
        }

    }
}
