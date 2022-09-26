using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using RiGa_V2.Model;
using RiGa_V2.Code.Validation;




namespace RiGa_V2.ViewModel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Reg_Page : ContentPage
    {
        public Reg_Page()
        {
            InitializeComponent();

            AccountTypePicker.Items.Add("Player");
            AccountTypePicker.Items.Add("Manager");
            AccountTypePicker.Items.Add("Developer");
            AccountTypePicker.SelectedItem = "Player";
        }

         async private void BtnRegister_OnClicked(object sender, EventArgs e)
        {
            if (ValidationVault.Email == true)
            {
                if (ValidationVault.Password == true)
                {
                    if (ValidationVault.ConfirmPassword == true)
                    {
                        User user = new User();
                        user.FirstName = FirstNameRegistrationEntry.Text;
                        user.LastName = LastnameRegistrationEntry.Text;
                        user.Email = EmailRegistrationEntry.Text;
                        user.Password = PasswordRegistrationEntry.Text;
                        user.AccountType = AccountTypePicker.SelectedItem.ToString();

                        List<User> DatabaseItems = await App.Database.GetAllItems();
                        if (DatabaseItems.Count == 0)
                        {
                            await App.Database.Insert(user);
                            await Navigation.PushAsync(new View.Home_Page());
                        }
                        else
                        {
                            foreach (User item in DatabaseItems)
                            {
                                if (item.Email == user.Email)
                                    await DisplayAlert("Registration Failed", "Email already registered, please use another.", "OK");
                                else
                                {
                                    await App.Database.Insert(user);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}