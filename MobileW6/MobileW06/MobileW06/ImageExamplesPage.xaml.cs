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
    public partial class ImageExamplesPage : ContentPage
    {
        public ImageExamplesPage()
        {
            InitializeComponent();

            var imageSource = new UriImageSource
            {
                Uri = new Uri("https://picsum.photos/1000"),
                //CachingEnabled = false

                CachingEnabled = true,
                CacheValidity = new TimeSpan(0,0,0,25)
            };

            MyImage.Source = imageSource;
            MyImage.Aspect = Aspect.AspectFill;



            // MyImage.Source = "https://picsum.photos/1000";
        }
    }
}