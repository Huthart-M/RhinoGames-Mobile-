using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using RiGa_V2.Data;
using RiGa_V2.Code;
using System.IO;

namespace RiGa_V2
{
    public partial class App : Application
    {   //We need to add the references here for the userpreferences
        public static IUserPreferences UserPreferences { get; set; }
        public static void Init(IUserPreferences userPreferencesImpl)
        {
            App.UserPreferences = userPreferencesImpl;
        }

        //Create DB/name it and specify path
        static Database database;
        public static Database Database
        {
            get
            {
                if (database == null)
                {
                    database = new Database(
                        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "RareMantis.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();
            //Handle the navigation and the setting of colours on content page selection.
            NavigationPage navigationPage = new NavigationPage(new MainPage());
            navigationPage.BarBackgroundColor = Color.Transparent;
            MainPage = navigationPage;
        }

        protected override void OnStart()
        {
            // Handle when your app onStartUp
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
