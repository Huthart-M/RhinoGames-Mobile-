using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using RiGa_V2.Code.Validation;
using RiGa_V2.Model;
using RiGa_V2.ViewModel;

namespace RiGa_V2.ViewModel
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login_Page : ContentPage
    {
        public Login_Page()
        {
            InitializeComponent();
        }
        async private void LoginButton_OnClicked(object sender, EventArgs e)
        {
            if (ValidationVault.LoginEmail == true)
            {
                if (ValidationVault.LoginPassword == true)
                {
                    User user = new User();
                    user.Email = EmailEntry.Text;
                    user.Password = PasswordEntry.Text;

                    List<User> DatabaseItems = await App.Database.GetAllItems();
                    foreach (User item in DatabaseItems)
                    {
                        if (item.Email == user.Email)
                        {
                            if (item.Password == user.Password)
                            {
                                Navigation navigation = new Navigation();
                                App.Current.MainPage = navigation;
                            }
                        }
                    }
                }
            }
        }
    }
}