using ElectionMobileApp.Models;
using ElectionMobileApp.Services;
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
    public partial class CustomMessageSendModal : Rg.Plugins.Popup.Pages.PopupPage
    {
        VoterInformation vInformation;
        public CustomMessageSendModal()
        {
            InitializeComponent();
        }
        public CustomMessageSendModal(VoterInformation voter)
        {
            vInformation = voter;
            InitializeComponent();
        }
        protected override bool OnBackButtonPressed()
        {
            // Return true if you don't want to close this popup page when a back button is pressed
            return base.OnBackButtonPressed();
        }
        CommonMethods commonMethod = new CommonMethods();
        private void btnSendCustomWPClicked(object sender, EventArgs e)
        {
            commonMethod.SendWhatsappMessage(vInformation.Mobile1);
        }
        private void btnSendCustomSMSClicked(object sender, EventArgs e)
        {
           var res = commonMethod.SendSMS(vInformation.Mobile1);
            if(!res.Result)
            {
                DisplayAlert("Something Went Wrong", res.Exception, "Close");
            }
        }
        protected override bool OnBackgroundClicked()
        {
            // Return false if you don't want to close this popup page when a background of the popup page is clicked
            return base.OnBackgroundClicked();
        }
    }
}