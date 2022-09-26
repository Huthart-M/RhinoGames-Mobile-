using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using RiGa_V2.View; 

namespace RiGa_V2.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Reasults_Page : ContentPage
    {
        public Reasults_Page()
        {
            InitializeComponent();
        }

        async private void Teams_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Teams_Page ());
        }
    }
}