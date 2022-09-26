using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RiGa_V2.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Teams_Page : ContentPage
    {
        public Teams_Page()
        {
            InitializeComponent();
        }

        async private void Reasults_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Reasults_Page());
        }
    }
}