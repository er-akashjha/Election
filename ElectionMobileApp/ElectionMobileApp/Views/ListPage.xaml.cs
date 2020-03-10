using ElectionMobileApp.ViewModels;
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
    public partial class ListPage
    {
        ListPageViewModel viewModel;
        public ListPage()
        {
            InitializeComponent();
            viewModel = new ListPageViewModel();
            ItemsListView.ItemsSource = viewModel.Items;
        }
        private async void LsFilterByTapped(object sender, ItemTappedEventArgs e)
        {
            var data = (ListView)sender;

            switch(data.SelectedItem.ToString())
            {
                case "Advance Search":
                    {

                        break;
                    }
                case "By Village":
                    {
                        break;
                    }
                case "By Part No":
                    {
                        break;
                    }
                case "By Address":
                    {
                        break;
                    }
                case "By Booth":
                    {
                        break;
                    }
                case "By Color":
                    {
                        break;
                    }
                case "By Cast":
                    {
                        break;
                    }
                case "By Age":
                    {
                        break;
                    }
                case "By Profession":
                    {
                        break;
                    }

                case "Dead":
                    {
                        break;
                    }
                case "Repeated":
                    {
                        break;
                    }
                case "Mobile Number":
                    {
                        break;
                    }
                case "Voted":
                    {
                        break;
                    }
                case "By New Address":
                    {
                        break;
                    }
                case "By Society":
                    {
                        break;
                    }
            }
         
            if (data.SelectedItem.ToString()== "Advance Search")
            {

            }

            //if (data. == "Survey")
            //{
            //    await Navigation.PushAsync(new Views.SurveyViews.VoterSurveyPage(data));
            //}
            //else
            //    await Navigation.PushAsync(new VoterInformationPage(data));

        }
    }
}