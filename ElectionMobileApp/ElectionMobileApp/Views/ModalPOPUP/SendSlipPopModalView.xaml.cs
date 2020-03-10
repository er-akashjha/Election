using ElectionMobileApp.Models;
using ElectionMobileApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ElectionMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SendSlipPopModalView : Rg.Plugins.Popup.Pages.PopupPage
    {
        VoterInformation vInformation;
        public SendSlipPopModalView()
        {
            InitializeComponent();
        }
        public SendSlipPopModalView(VoterInformation voter)
        {
            vInformation = voter;
            InitializeComponent();
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
        CommonMethods commonMethods = new CommonMethods();

        
        private void btnSendSlipSameNameClicked(object sender, EventArgs e)
        {
            var res = commonMethods.SendWhatsappMessage(vInformation.Mobile1, commonMethods.getVoterSlip(vInformation));
            if (!res.Result)
            {
                DisplayAlert("Something Went Wrong", res.Exception, "Close");
            }
        }
      

        private void btnSendSlipVoterClicked(object sender, EventArgs e)
        {
            var res = commonMethods.SendWhatsappMessage(vInformation.Mobile1, commonMethods.getVoterSlip(vInformation));
            if(!res.Result)
            {
                DisplayAlert("Something Went Wrong", res.Exception, "Close");
            }
        }
        private void btnSendSlipFamilyClicked(object sender, EventArgs e)
        {
            var res = commonMethods.SendWhatsappMessage(vInformation.Mobile1, commonMethods.getVoterSlip(vInformation));
            if (!res.Result)
            {
                DisplayAlert("Something Went Wrong", res.Exception, "Close");
            }
        }
        //btnSendSlipFamilyClicked
    }
}