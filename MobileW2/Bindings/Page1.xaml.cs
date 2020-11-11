using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MobileW2
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            lblMessage.Opacity=0;
        }

        void Slider_ValueChanged(System.Object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            //lblValue.Text =string.Format("{0:F2}",  slider.Value);
            //lblMessage.Opacity = slider.Value;

            //lblValue.Text =string.Format("{0:F2}",  e.NewValue);
            //lblMessage.Opacity = e.NewValue;

            var obj = (Slider)sender;

            lblValue.Text = string.Format("{0:F2}", obj.Value);
            lblMessage.Opacity = obj.Value;
        }
    }
}
