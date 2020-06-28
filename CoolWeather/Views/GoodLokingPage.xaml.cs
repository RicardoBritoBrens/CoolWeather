
using CoolWeather.ViewModels;
using Xamarin.Forms;

namespace CoolWeather.Views
{
    public partial class GoodLokingPage : ContentPage
    {
        public GoodLokingPage()
        {
            InitializeComponent();
            ViewModels = new GoodLogingPageViewModel();
        }

        public GoodLogingPageViewModel ViewModels
        {
            get => BindingContext as GoodLogingPageViewModel;
            set => BindingContext = value;
        }
    }
}
