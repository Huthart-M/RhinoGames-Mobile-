using System;
using System.Collections.Generic;
using System.Text;
//add ns
using Xamarin.Forms;

namespace RiGa_V2.Code.Validation
{
    public class PasswordValidation : Behavior<Entry>
    {

        protected override void OnAttachedTo(Entry bindable)
        {
            base.OnAttachedTo(bindable);

            bindable.TextChanged += BindableOnTextChanged;
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            base.OnDetachingFrom(bindable);

            bindable.TextChanged -= BindableOnTextChanged;
        }

        private void BindableOnTextChanged(object sender, TextChangedEventArgs e)
        {
            var Password = e.NewTextValue;
            var Entry = sender as Entry;

            if (IsPasswordValid(Password) == true)
            {
                Entry.TextColor = Color.Default;
                ValidationVault.Password = true;
            }
            else
            {
                Entry.TextColor = Color.Red;
                ValidationVault.Password = false;
            }
        }

        private bool IsPasswordValid(string password)
        {
            //Make a stronger password by increasing the length requirements
            if (password.Length > 2)
            {
                ValidationVault.StoredPasswordValidation = password;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}