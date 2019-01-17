using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ControlTemplateSample.Views.Templates
{
    public partial class TemplateFour : Grid
    {
        public TemplateFour()
        {
            InitializeComponent();
        }

        void Handle_Toggled(object sender, Xamarin.Forms.ToggledEventArgs e)
        {
            if(e.Value)
            {
                nameLabel.Rotation = 180;
                descriptionLabel.Rotation = 180;
            }
            else
            {
                nameLabel.Rotation = 0;
                descriptionLabel.Rotation = 0;
            }
        }
    }
}
