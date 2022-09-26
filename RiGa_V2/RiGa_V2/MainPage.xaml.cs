using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using RiGa_V2.ViewModel;

namespace RiGa_V2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async public void LoginBTN(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login_Page());
        }

        async public void RegBTN(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Reg_Page());
        }

    }
}
