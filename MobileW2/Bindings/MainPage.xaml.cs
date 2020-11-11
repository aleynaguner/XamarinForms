using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileW2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Calculate_Button_Clicked(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtNumber1.Text);

            int num2 = Convert.ToInt32(txtNumber2.Text);

            int res = num1 + num2;

            lblResult.Text = res.ToString();
        }

       
    }
}
