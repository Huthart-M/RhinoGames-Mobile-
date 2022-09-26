using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using RiGa_V2.Code;
using Plugin.CurrentActivity;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms; 

namespace RiGa_V2.Droid
{
    public class AndroidUserPreference : MainActivity, IUserPreferences
    {
        public void SetColor(Xamarin.Forms.Color currentColor)
        {
            var currentWindow = GetCurrentWindow();
            Android.Graphics.Color convertColor = currentColor.ToAndroid();
            currentWindow.SetStatusBarColor(convertColor);
        }

        Window GetCurrentWindow()
        {
            var window = CrossCurrentActivity.Current.Activity.Window;

            // clear FLAG_TRANSLUCENT_STATUS flag:
            window.ClearFlags(WindowManagerFlags.TranslucentStatus);

            // add FLAG_DRAWS_SYSTEM_BAR_BACKGROUNDS flag to the window
            window.AddFlags(WindowManagerFlags.DrawsSystemBarBackgrounds);

            return window;
        }
    }
}