using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;

namespace DroneLander
{
    public partial class App : Application
    {
        public static MainViewModel ViewModel { get; set; }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new DroneLander.MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            MobileCenter.Start("uwp=3b3dc31f-bb0d-4a37-85a2-aedd30508b36;" +
                               "android={Your Android App secret here}" +
                               "ios={Your iOS App secret here}",
                               typeof(Analytics));
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
