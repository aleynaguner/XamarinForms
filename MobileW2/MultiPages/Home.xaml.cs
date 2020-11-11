using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MobileW2.MultiPages
{
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
           await Navigation.PushAsync(new Detail());
        }
    }
}
