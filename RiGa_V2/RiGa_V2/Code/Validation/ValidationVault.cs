using System;
using System.Collections.Generic;
using System.Text;

namespace RiGa_V2.Code.Validation
{
    public static class ValidationVault
    {
        public static string StoredPasswordValidation;
        public static string StoredEmailValidation;
        //For the registration
        public static bool Email = false;
        public static bool Password = false;
        public static bool ConfirmPassword = false;
        //For the login page
        public static bool LoginEmail = false;
        public static bool LoginPassword = false;
    }
}