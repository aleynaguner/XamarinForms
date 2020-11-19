using Xamarin.Forms;

namespace MobileW06
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ActivityIndicatorPage();
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
