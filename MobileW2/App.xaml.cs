using System;
using MobileW2.Layouts.StackLayout;
using MobileW2.MultiPages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileW2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new NavigationPage( new Home());
            MainPage = new StkExample3();
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
