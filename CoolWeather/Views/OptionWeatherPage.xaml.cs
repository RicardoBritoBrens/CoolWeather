using System;
using System.Collections.Generic;
using CoolWeather.ViewModels;
using Xamarin.Forms;

namespace CoolWeather.Views
{
    public partial class OptionWeatherPage : ContentPage
    {
        public OptionWeatherPage()
        {
            InitializeComponent();
            var pageService = new PageService();
            ViewModel = new OptionWeatherPageViewModel(pageService);
        }

        public OptionWeatherPageViewModel ViewModel
        {
            get => BindingContext as OptionWeatherPageViewModel;
            set
            {
                BindingContext = value;
            }
        }

        void CurrentLocationTapped(System.Object sender, System.EventArgs e)
        {
            (BindingContext as OptionWeatherPageViewModel).CallCurrentLocationPageCommand.Execute(null);
        }

        void PickCityElementTapped(System.Object sender, System.EventArgs e)
        {
            (BindingContext as OptionWeatherPageViewModel).CallPickCityPageCommand.Execute(null);
        }

    }
}
