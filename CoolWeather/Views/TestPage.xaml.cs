using System;
using System.Collections.Generic;
using CoolWeather.ViewModels;
using Xamarin.Forms;

namespace CoolWeather.Views
{
    public partial class TestPage : ContentPage
    {
        public TestPage()
        {
            InitializeComponent();
            ViewModels = new TestPageViewModel();
        }

        public TestPageViewModel ViewModels
        {
            get => BindingContext as TestPageViewModel;
            set => BindingContext = value;
        }
    }
}
