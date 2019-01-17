using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ControlTemplateSample.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public string Title { get; set; } = "Content Templates";
        public string Name { get; set; }
        public string Description { get; set; }
        public string Message => "Hello Xamarin Forms" + System.Environment.NewLine + System.Environment.NewLine + "Using Templates";
        public IList<string> Names { get; set; } = new List<string>()
        {
            "Juan",
            "Jose",
            "Felipe",
            "Pedro",
            "Ramon",
            "Luis"
        };

        public MainViewModel()
        {
           
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
