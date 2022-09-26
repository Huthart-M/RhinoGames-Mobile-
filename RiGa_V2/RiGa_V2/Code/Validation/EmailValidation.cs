using System;
using System.Collections.Generic;
using System.Text;
//add the Namespace
using Xamarin.Forms;
using System.Text.RegularExpressions;
namespace RiGa_V2.Code.Validation
{
    public class EmailValidation : Behavior<Entry>
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

            if (IsEmailValid(Email) == true)
            {
                Entry.TextColor = Color.Default;
                ValidationVault.Email = true;
            }
            else
            {
                Entry.TextColor = Color.Red;
                ValidationVault.Email = false;
            }
        }

        private bool IsEmailValid(string address)
        {
            //Do the regEx to get a properly formed email address
            return Regex.IsMatch(address, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }
    }
}
