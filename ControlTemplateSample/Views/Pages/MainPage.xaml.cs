using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlTemplateSample.Views.Templates;
using ControlTemplateSample.ViewModels;
using Xamarin.Forms;

namespace ControlTemplateSample.Views.Pages
{
    public partial class MainPage : ContentPage
    {

        int templateIndex = 0;

        //Templates
        ControlTemplate template1 = new ControlTemplate(typeof(TemplateOne));
        ControlTemplate template2 = new ControlTemplate(typeof(TemplateTwo));
        ControlTemplate template3 = new ControlTemplate(typeof(TemplateThree));
        ControlTemplate template4 = new ControlTemplate(typeof(TemplateFour));

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
            ControlTemplate = template1;

        }

        void SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var index = picker.SelectedIndex;
            if (index != templateIndex)
            {
                switch (index)
                {
                    case 0:
                        ControlTemplate = template1;
                        break;
                    case 1:
                        ControlTemplate = template2;
                        break;
                    case 2:
                        ControlTemplate = template3;
                        break;
                    case 3:
                        ControlTemplate = template4;
                        break;
                }

                templateIndex = index;
            }
        }
    }
}
