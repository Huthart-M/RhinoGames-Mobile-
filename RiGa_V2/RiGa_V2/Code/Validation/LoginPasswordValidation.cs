using System;
using System.Collections.Generic;
using System.Text;
//add NS
using Xamarin.Forms;

namespace RiGa_V2.Code.Validation
{
    public class LoginPasswordValidation : Behavior<Entry>
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
                ValidationVault.LoginPassword = true;
            }
            else
            {
                Entry.TextColor = Color.Red;
                ValidationVault.LoginPassword = false;
            }
        }

        private bool IsPasswordValid(string password)
        {
            if (password.Length > 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
