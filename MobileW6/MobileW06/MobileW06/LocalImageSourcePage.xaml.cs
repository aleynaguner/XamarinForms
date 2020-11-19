using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileW06
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LocalImageSourcePage : ContentPage
    {
        public LocalImageSourcePage()
        {
            InitializeComponent();

            if (Device.RuntimePlatform == Device.Android)
            {
                MyImage.Source =ImageSource.FromFile("bg1.jpg");
            }

            if (Device.RuntimePlatform == Device.iOS)
            {
                MyImage.Source = ImageSource.FromFile("bg2.jpg");
            }
        }
    }
}