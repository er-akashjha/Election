using Rg.Plugins.Popup.Extensions;
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
    public partial class VoterInformationSearchModal : Rg.Plugins.Popup.Pages.PopupPage
    {
        public VoterInformationSearchModal()
        {
            InitializeComponent();
        }
        async void Save_Clicked(object sender, EventArgs e)
        {
            // MessagingCenter.Send(this, "AddItem", Item);
            await DisplayAlert("In Save Method", "Kya message bro", "OK");
            await Navigation.PopModalAsync();
        }
        async void btnSearchWithNameCicked(object sender, EventArgs e)
        {
            // MessagingCenter.Send(this, "AddItem", Item);
            MessagingCenter.Send<string>("FiterWithSameName", "SearchFilterSelected");
            await Navigation.PopPopupAsync();
        }
        async void btnSearchForFamilyClicked(object sender, EventArgs e)
        {
            // MessagingCenter.Send(this, "AddItem", Item);
            MessagingCenter.Send<string>("FiterWithFamily", "SearchFilterSelected");

            await Navigation.PopPopupAsync();
        }
        async void btnSearchForVotersOnSameAddress(object sender, EventArgs e)
        {
            // MessagingCenter.Send(this, "AddItem", Item);
            MessagingCenter.Send<string>("FiterWithSameAddress", "SearchFilterSelected");
            await Navigation.PopPopupAsync();
        }
        async void btnSearchForVoterOnSameBooth(object sender, EventArgs e)
        {
            // MessagingCenter.Send(this, "AddItem", Item);
            MessagingCenter.Send<string>("FiterWithSameBooth", "SearchFilterSelected");
            await Navigation.PopPopupAsync();
        }


        protected override bool OnBackButtonPressed()
        {
            // Return true if you don't want to close this popup page when a back button is pressed
            return base.OnBackButtonPressed();
        }

        // Invoked when background is clicked
        protected override bool OnBackgroundClicked()
        {
            // Return false if you don't want to close this popup page when a background of the popup page is clicked
            return base.OnBackgroundClicked();
        }
    }
}