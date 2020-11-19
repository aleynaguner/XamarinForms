using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileW05.Resources
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DynamicResourcePage : ContentPage
    {
        public DynamicResourcePage()
        {
            InitializeComponent();
        }

        private void SaveButton_OnClicked(object sender, EventArgs e)
        {
            this.Resources["MyColor"] = Color.Red;
            this.Resources["MyColor1"] = Color.Blue;
            this.Resources["Data"] = "Colors Inverted";

        }


        private void TxtFirsName_OnFocused(object sender, FocusEventArgs e)
        {

            this.Resources["FocusedColor"] = Color.Chartreuse;
        }

        private void TxtFirsName_OnUnfocused(object sender, FocusEventArgs e)
        {
            this.Resources["FocusedColor"] = Color.White;
        }
    }
}