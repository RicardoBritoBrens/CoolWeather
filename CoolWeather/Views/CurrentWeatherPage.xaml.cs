using System;
using System.Collections.Generic;
using CoolWeather.Services.Navigation;
using CoolWeather.ViewModels;
using Xamarin.Forms;

namespace CoolWeather.Views
{
    public partial class CurrentWeatherPage : ContentPage
    {
        public CurrentWeatherPage()
        {
            InitializeComponent();
            var pageService = new PageService();
            ViewModel = new CurrentWeatherPageViewModel(pageService);
        }

        public CurrentWeatherPageViewModel ViewModel
        {
            get => BindingContext as CurrentWeatherPageViewModel;
            set => BindingContext = value;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            (BindingContext as CurrentWeatherPageViewModel).GetCitiesCommand.Execute(null);
        }
    }
}
