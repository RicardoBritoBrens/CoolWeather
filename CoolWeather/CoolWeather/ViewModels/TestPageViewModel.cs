using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CoolWeather.ViewModels
{
    public class TestPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
