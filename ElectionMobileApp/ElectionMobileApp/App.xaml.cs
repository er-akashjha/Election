using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ElectionMobileApp.Services;
using ElectionMobileApp.Views;

namespace ElectionMobileApp
{
    public partial class App : Application
    {

        public App()
        {
            try
            {

                InitializeComponent();

                DependencyService.Register<MockDataStore>();
                MainPage = new MainPage();
            }
            catch(Exception er)
            {

            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
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
