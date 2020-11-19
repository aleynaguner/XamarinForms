using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileW06
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActivityIndicatorPage : ContentPage
    {
        public ActivityIndicatorPage()
        {
            InitializeComponent();

            var imageSource = new UriImageSource
            {
                Uri = new Uri("https://picsum.photos/2000"),
                //CachingEnabled = false

                CachingEnabled = true,
                CacheValidity = new TimeSpan(0, 0, 0, 25)
            };

           // Thread.Sleep(5000);
            MyImage.Source = imageSource;
            MyImage.Aspect = Aspect.AspectFill;
        }
    }
}