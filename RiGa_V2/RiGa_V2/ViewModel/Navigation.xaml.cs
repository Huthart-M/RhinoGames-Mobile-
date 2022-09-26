using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
//add NS
using BottomBar.XamarinForms;
//ns test
using RiGa_V2.Code;
using RiGa_V2.Data;
using BottomBar;
using RiGa_V2.ViewModel;


namespace RiGa_V2.ViewModel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    //Ensure you change the reference below to BottomBarPage as it will currently be the contentpage.
    public partial class Navigation : BottomBarPage
    {
        public Navigation()
        {
            InitializeComponent();

            Color[] colorList = new Color[] { Color.FromHex("#001845"), Color.FromHex("#002855"), Color.FromHex("#023E75"), Color.FromHex("#0353A4"), Color.FromHex("#0466CB") };
            this.CurrentPageChanged += (object sender, EventArgs e) =>
            {
                var i = this.Children.IndexOf(this.CurrentPage);
                //The UserPreferences will appear red, until we code the UserPreferences
                App.UserPreferences.SetColor(colorList[i]);
            };
        }
    }
}