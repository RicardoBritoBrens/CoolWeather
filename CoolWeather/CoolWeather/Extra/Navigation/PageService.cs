﻿using System.Threading.Tasks;
using Xamarin.Forms;

namespace CoolWeather.Services.Navigation
{
    public class PageService : IPageService
    {
        public INavigation Navigation { get; set; }

        public async Task DisplayAlert(string title, string message, string ok)
        {
            await MainPage.DisplayAlert(title, message, ok);
        }

        public async Task<bool> DisplayAlert(string title, string message, string ok, string cancel)
        {
            return await MainPage.DisplayAlert(title, message, ok, cancel);
        }

        public async Task PushAsync(Page page)
        {
            await MainPage.Navigation.PushAsync(page);
        }

        public PageService(INavigation navigation)
        {
            Navigation = navigation;
        }

        public PageService()
        {
        }

        public async Task<Page> PopAsync()
        {
            return await MainPage.Navigation.PopAsync();
        }

        private Page MainPage
        {
            get { return Application.Current.MainPage; }
        }
    }
}
