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
    public partial class SurveyHomePage : ContentPage
    {
        List<string> options = new List<string>();
        public SurveyHomePage()
        {
            InitializeComponent();
            List<string> options = new List<string>();
            options.Add("Survey");
            options.Add("New Voters");
            options.Add("View Voted");
            options.Add("Clear Voted Marking");
            lsSurvey.ItemsSource = options;
        }
        
        private async void LsSurvey_ItemTappedAsync(object sender, ItemTappedEventArgs e)
        {
            var ls = (ListView)sender;
            switch(ls.SelectedItem)
            {
                case "Survey":
                    {
                        await Navigation.PushAsync(new SearchPage("Survey"));
                        break;
                    }
                case "New Voters":
                    {
                        break;
                    }
                case "View Voted":
                    {
                        break;
                    }
                case "Clear Voted Marking":
                    {
                        break;
                    }
            }
        }
    }
}