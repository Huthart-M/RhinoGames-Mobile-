  using System;
using System.Collections.Generic;
using System.Text;
//ADD NS
using Xamarin.Forms;

namespace RiGa_V2.Code.Validation
{
    public class ConfirmPasswordValidation : Behavior<Entry>
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

            if (IsConfirmPasswordValid(Password) == true)
            {
                Entry.TextColor = Color.Default;
                ValidationVault.ConfirmPassword = true;
            }
            else
            {
                Entry.TextColor = Color.Red;
                ValidationVault.ConfirmPassword = true;
            }
        }

        private bool IsConfirmPasswordValid(string password)
        {

            string storedPassword = ValidationVault.StoredPasswordValidation;
            if (storedPassword != null)
            {
                if (storedPassword.Equals(password) == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
