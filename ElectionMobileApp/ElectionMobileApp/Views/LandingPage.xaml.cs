using ElectionMobileApp.Views.mama;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ElectionMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LandingPage : ContentPage
    {
        public LandingPage()
        {
            InitializeComponent();
        }
        private async void Btn_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch(btn.Text)
            {
                case "Search" :
                    {
                         await Navigation.PushAsync(new SearchPage());
                       // await Navigation.PushModalAsync(new SearchPage());
                        break;
                    }
                case "List":
                    {
                        await Navigation.PushAsync(new ListPage());
                        break;
                    }
                case "Survey":
                    {
                        await Navigation.PushAsync(new SurveyHomePage());
                        break;
                    }
                case "Charts":
                    {
                        break;
                    }
                case "Other":
                    {
                        await Navigation.PushAsync(new addMessage());
                        break;
                    }
                case "Language":
                    {
                        break;
                    }
            }
        }
    }
}