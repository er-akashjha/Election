using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ElectionMobileApp.Views
{
 //   [XamlCompilation(XamlCompilationOptions.Compile)]
    [DesignTimeVisible(true)]
    public partial class Registration : ContentPage
    {
        public Registration()
        {
            InitializeComponent();
        }

        private async void BtnActivate_Clicked(object sender, EventArgs e)
        {
            //App.Current.MainPage = new LandingPage();
           // value = NavigationPage(new LandingPage());
            await Navigation.PushAsync(new LandingPage());
        }
    }
}