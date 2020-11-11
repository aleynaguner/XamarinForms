using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MobileW2.MultiPages
{
    public partial class Detail : ContentPage
    {
        public Detail()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
           await Navigation.PopAsync();
        }
    }
}
