using System;
using MobileW05.Resources;
using MobileW05.XamarinControls;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileW05
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ControlsPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
