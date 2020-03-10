using ElectionMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectionMobileApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ElectionMobileApp.Views
{
   
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchPage : ContentPage
    {
       // List<VoterInformation> obj;
        VoterInformationViewModel viewModel;
        string RequestedFrom = string.Empty;
        public SearchPage()
        {
            InitializeComponent();
            viewModel = new VoterInformationViewModel();
        }
        public SearchPage(string requestedFrom)
        {
            InitializeComponent();
            viewModel = new VoterInformationViewModel();
            RequestedFrom = requestedFrom;
        }
        private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                var entry = (SearchBar)sender;
               txtSearch.TextChanged -= OnSearchTextChanged;
                if(txtSearch.Text!="")
                {
                    var filterdRecord =
                   viewModel.Items.Where(user => (user.Name.Contains(txtSearch.Text) || user.RelativeName.Contains(txtSearch.Text) || user.Village.Contains(txtSearch.Text) || user.Village.Contains(txtSearch.Text) || user.Assembly.Contains(txtSearch.Text))).ToList();
                    lsVoterList.ItemsSource = filterdRecord;
                    lblTotalRecord.Text = "Filtered Records : " + filterdRecord.Count.ToString();
                }
                else
                {
                    lsVoterList.ItemsSource = viewModel.Items;
                    lblTotalRecord.Text = "Total Records : " + viewModel.Items.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught: {0}", ex);
            }
            finally
            {
                txtSearch.TextChanged += OnSearchTextChanged;
            }
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Items.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);

            lsVoterList.ItemsSource = viewModel.Items;
            lblTotalRecord.Text = "Total Records : "+viewModel.Items.Count.ToString();
            txtSearch.TextChanged -= OnSearchTextChanged;
            txtSearch.Text = "";
            txtSearch.TextChanged += OnSearchTextChanged;

        }

        private async void LsVoterList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var data = e.Item as VoterInformation;
            if(RequestedFrom=="Survey")
            {
                // await Navigation.PushAsync(new Views.SurveyViews.VoterSurveyPage(data));
                await Navigation.PushAsync(new VoterInfoAndSurvey(data));
            }
            else
                await Navigation.PushAsync(new VoterInformationPage(data));

        }

        private async void LsVoterList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
           // var data = e.SelectedItem as VoterInformation;
           // await Navigation.PushAsync(new VoterInformationPage(data));
        }
    }
}