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
    public partial class StaticResourceCODEPage : ContentPage
    {
        public StaticResourceCODEPage()
        {
            InitializeComponent();

            MyLabel1.Text = this.Resources["Data"].ToString();
            MyLabel1.TextColor =(Color) Resources["MyColor"];

            MyLabel2.Text = this.Resources["Data"].ToString();
            MyLabel2.TextColor = (Color)Resources["MyColor1"];

            SaveButton.BackgroundColor = (Color)Resources["SaveButtonColor"];
        }
    }
}