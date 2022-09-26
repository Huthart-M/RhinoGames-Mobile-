using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace RiGa_V2.Code.Validation
{
    class ConfirmEmailValidation : Behavior<Entry>
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
            var Email = e.NewTextValue;
            var Entry = sender as Entry;

            if (IsConfirmEmailValid(Email) == true)
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

        private bool IsConfirmEmailValid(string email)
        {

            string storedPassword = ValidationVault.StoredEmailValidation;
            if (storedPassword != null)
            {
                if (storedPassword.Equals(email) == true)
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

