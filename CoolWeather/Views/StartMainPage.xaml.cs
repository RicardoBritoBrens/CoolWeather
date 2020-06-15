using System;
using System.Collections.Generic;
using CoolWeather.Services.Navigation;
using CoolWeather.ViewModels;
using Xamarin.Forms;

namespace CoolWeather.Views
{
    public partial class StartMainPage : ContentPage
    {
        public StartMainPage()
        {
            InitializeComponent();
            var pageService = new PageService();
            ViewModel = new StartMainPageViewModel(pageService);
        }

        public StartMainPageViewModel ViewModel
        {
            get => BindingContext as StartMainPageViewModel;
            set => BindingContext = value;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            (BindingContext as StartMainPageViewModel).GetCitiesCommand.Execute(null);
        }
    }
}
