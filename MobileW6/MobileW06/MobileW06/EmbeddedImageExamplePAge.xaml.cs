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
    public partial class EmbeddedImageExamplePAge : ContentPage
    {
        public EmbeddedImageExamplePAge()
        {
            InitializeComponent();
           // MyImage.Source = ImageSource.FromResource("MobileW06.Images.background1.jpeg");
        }
    }
}