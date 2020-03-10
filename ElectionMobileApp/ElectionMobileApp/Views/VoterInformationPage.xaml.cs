using ElectionMobileApp.Models;
using ElectionMobileApp.ViewModels;
using Rg.Plugins.Popup.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Extensions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Android.Content.PM;
using Android.Content;
using Xamarin.Essentials;
using Plugin.Messaging;
using ElectionMobileApp.Views.ModalPOPUP;
using ElectionMobileApp.Services;

namespace ElectionMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VoterInformationPage : ContentPage
    {
        //VoterInformationViewModel viewModel;
        VoterInformation vi;
        SQLiteVoterInformationExtended sQLiteVoterInformationExtended;
        VoterInformationExtended objVoterInformationExtended;
        
        public VoterInformationPage(VoterInformation selectedData)
        {
            InitializeComponent();
            //Here add the logic to get only those which is missing.
            sQLiteVoterInformationExtended = new SQLiteVoterInformationExtended();
            objVoterInformationExtended = new VoterInformationExtended();
            setData(selectedData);
          
        }
        //private async void Search_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushPopupAsync(new VoterInformationSearchModal());
        //    await DisplayAlert("","This is obsolete","Close");
        //}
        private async void btnSurveyClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.SurveyViews.VoterSurveyPage(vi));
        }
        private void setData(VoterInformation info)
        {
            vi = info;
            objVoterInformationExtended.ID = vi.ID;
            lblAddress.Text = info.Address;
            lblAgeGender.Text = info.Age + " " + info.Gender;
            lblAssembly.Text = info.Assembly;
            lblBooth.Text = info.Booth;
            lblHouseNo.Text = info.HouseNumber;
            lblMobile1.Text = info.Mobile1;
            lblName.Text = info.Name +" "+info.RelativeName;
            lblPartNumber.Text = (info.PartNumber).ToString();
            lblSrno.Text = info.SNo.ToString();
            lblVillage.Text = info.Village;
            lblVoterID.Text = info.VoterID;
            
            swIsDead.IsToggled = info.Dead;
            
            var extendedData = sQLiteVoterInformationExtended.Get(vi.ID);
            if(extendedData!=null)
            {
                objVoterInformationExtended = extendedData;
                if (extendedData.isVotingUs != null && extendedData.isVotingUs != "")
                {
                    switch (extendedData.isVotingUs)
                    {
                        case "OURS":
                            {
                                btnOther.BackgroundColor = Color.LightGreen;
                                btnOther.Text = "OURS";
                                break;
                            }
                        case "OPPOSITE":
                            {
                                btnOther.BackgroundColor = Color.Red;
                                btnOther.Text = "OPPOSITE";
                                break;
                            }
                        case "DOUBTFUL":
                            {
                                btnOther.BackgroundColor = Color.Yellow;
                                btnOther.Text = "DOUBTFUL";
                                break;
                            }
                    }
                }
                if(extendedData.isVoted)
                {
                    btnNonVoted.BackgroundColor = Color.LightSkyBlue;
                    btnNonVoted.Text = "Voted";
                }
                if(extendedData.isCalled)
                {
                    btnPhone.Source = "PhoneYellow.png";
                }
                if(extendedData.isFavourate)
                {
                    btnFav.Source = "RatingYellow.png";
                }
                
            }
        }
        private void isHeVoting(object sender, EventArgs e)
        {
            Navigation.PushPopupAsync(new IsHeVotingUS());
            MessagingCenter.Subscribe<string>(this, "ISVoterVotingUS", (value) =>
            {
                if (value == "OURS")
                {
                    btnOther.BackgroundColor = Color.LightGreen;
                    btnOther.Text = "OURS";
                }
                else if (value == "OPPOSITE")
                {
                    btnOther.BackgroundColor = Color.Red;
                    btnOther.Text = value;
                }
                else if (value == "DOUBTFUL")
                {
                    btnOther.BackgroundColor = Color.Yellow;
                    btnOther.Text = value;
                }
                else
                {
                    btnOther.BackgroundColor = Color.WhiteSmoke;
                    btnOther.Text = "OTHER";
                }
                objVoterInformationExtended.isVotingUs = value;
            });
            
           // MessagingCenter.Unsubscribe<string>(this, "ISVoterVotingUS");
        }
        private void btnNonVotedClicked(object sender, EventArgs e)
        {
            if (btnNonVoted.BackgroundColor == Color.WhiteSmoke)
            {
                objVoterInformationExtended.isVoted = true;
                btnNonVoted.BackgroundColor = Color.LightSkyBlue;
                btnNonVoted.Text = "Voted";
            }
            else
            {
                objVoterInformationExtended.isVoted = false;
                btnNonVoted.BackgroundColor = Color.WhiteSmoke;
                btnNonVoted.Text = "NON VOTED";
            }
            //ERP : ODOO | 
        }
        private async void btnWhatsapp_Clicked(object sender, EventArgs e)
        {
            
            await Navigation.PushPopupAsync(new CustomMessageSendModal(vi));
           // SendWhatsappMessage(lblMobile1.Text, "This is a Test Message");
        }
        private void btnRating_Clicked(object sender, EventArgs e)
        {
            objVoterInformationExtended.isFavourate = true;
            btnFav.Source = "RatingYellow.png";
        }
        private void btnAddContactClicked(object sender, EventArgs e)
        {
            //Navigation.PushPopupAsync(new IsHeVotingUS());
            //MessagingCenter.Subscribe<string>(this, "ContactNumberUpdate", (value) =>
            //{
            //    objVoterInformationExtended.isVotingUs = value;
            //});
        }
        private void btnCallClicked(object sender, EventArgs e)
        {
            var phoneDialer = CrossMessaging.Current.PhoneDialer;
            if(phoneDialer.CanMakePhoneCall)
            {
                objVoterInformationExtended.isCalled = true;
                btnPhone.Source = "PhoneYellow.png";
                phoneDialer.MakePhoneCall(vi.Mobile1,vi.Name);
            }
        }
        public async void SendWhatsappMessage(string phoneNumber, string message = null)
        {
            try
            {
                var uriString = "whatsapp://send?phone=" +91+phoneNumber;
                if (!string.IsNullOrWhiteSpace(message))
                    uriString += "&text=" + message;
                await Launcher.OpenAsync(new Uri(uriString));
                // await DisplayAlert("Completed with ", "Pta nahi", "Close");
                objVoterInformationExtended.isVoterSlipSent = true;
            }
            catch (Exception ex)
            {
               await DisplayAlert("Exception",ex.Message,"Close");
            }
        }
        private async void btnSendSlip_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushPopupAsync(new SendSlipPopModalView(vi));
            //SendWhatsappMessage(lblMobile1.Text, "This is a Test Message");
        }
        protected override void OnDisappearing()
        {
            MessagingCenter.Unsubscribe<string>(this, "ISVoterVotingUS");
            sQLiteVoterInformationExtended.Insert(objVoterInformationExtended);
        }
    }
}