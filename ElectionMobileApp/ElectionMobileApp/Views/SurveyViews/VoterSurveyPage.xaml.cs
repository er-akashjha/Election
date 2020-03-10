using ElectionMobileApp.Models;
using ElectionMobileApp.Services;
using ElectionMobileApp.Views.ModalPOPUP;
using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ElectionMobileApp.Views.SurveyViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VoterSurveyPage : ContentPage
    {
        CommonMethods objCommonMethods = new CommonMethods();
        CommonLists lists = new CommonLists();
        VoterInformation vi;
        public VoterSurveyPage()
        {
            InitializeComponent();
            ddlCaste.ItemsSource = lists.getCaste();
            ddlOccupation.ItemsSource = lists.getOccupation();
        }
        public VoterSurveyPage(VoterInformation selectedData)
        {
            InitializeComponent();
            // viewModel = new VoterInformationViewModel();
            //Here add the logic to get only those which is missing.
            ddlCaste.ItemsSource = lists.getCaste();
            ddlOccupation.ItemsSource = lists.getOccupation();
            setData(selectedData);
        }
        private void setData(VoterInformation info)
        {
             vi = info;
            lblAddress.Text = info.Address;
            lblAgeGender.Text = info.Age + " " + info.Gender;
            lblAssembly.Text = info.Assembly;
            lblBooth.Text = info.Booth;
            lblHouseNo.Text = info.HouseNumber;
            lblMobile1.Text = info.Mobile1;
            lblName.Text = info.Name + " " + info.RelativeName;
            lblPartNumber.Text = (info.PartNumber).ToString();
            lblSrno.Text = info.SNo.ToString();
            lblVillage.Text = info.Village;
            lblVoterID.Text = info.VoterID;
        }
        private void DdlCaste_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ddl = (Picker)sender;
            lblCaste.Text = ddl.SelectedItem.ToString();
        }
        private void DdlOccupation_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ddl = (Picker)sender;
            lblOccupation.Text = ddl.SelectedItem.ToString();
        }
        private void CalDOB_DateSelected(object sender, DateChangedEventArgs e)
        {

        }
        private void btnCallClicked(object sender, EventArgs e)
        {
           var result = objCommonMethods.MakePhoneCall(vi.Mobile1, vi.Name);
           if (!result.Result)
           {
                DisplayAlert("Error, while making a call",result.Exception , "Close");
           }
           //ERP : ODOO | 
        }
        private void btnFavourateClicked(object sender, EventArgs e)
        {
            if (btnFav.BackgroundColor == Color.WhiteSmoke)
                btnFav.BackgroundColor = Color.Yellow;
            else
                btnFav.BackgroundColor = Color.WhiteSmoke;
            //ERP : ODOO | 
        }
        private void btnOthersClicked(object sender, EventArgs e)
        {
           // await 
           Navigation.PushPopupAsync(new IsHeVotingUS());
            //ERP : ODOO | 
            MessagingCenter.Subscribe<string>(this, "ISVoterVotingUS", (value) =>
              {
                  if (value == "OURS")
                  {
                      btnOther.BackgroundColor = Color.LightGreen;
                      btnOther.Text = "OURS";
                  }
                  else if(value== "OPPOSITE")
                  {
                      btnOther.BackgroundColor = Color.Red;
                      btnOther.Text = value;
                  }
                  else if(value=="DOUBTFUL")
                  {
                      btnOther.BackgroundColor = Color.Yellow;
                      btnOther.Text = value;
                  }
                  else
                  {
                      btnOther.BackgroundColor = Color.WhiteSmoke;
                      btnOther.Text = "OTHER";
                  }
              });
           // 
        }
        private void btnNonVotedClicked(object sender, EventArgs e)
        {
            if (btnNonVoted.BackgroundColor == Color.WhiteSmoke)
            {
                btnNonVoted.BackgroundColor = Color.LightSkyBlue;
                btnNonVoted.Text = "Voted";
                    }
            else
            {
                btnNonVoted.BackgroundColor = Color.WhiteSmoke;
                btnNonVoted.Text = "NON VOTED";
            }
            //ERP : ODOO | 
        }

        protected override void OnDisappearing()
        {
            MessagingCenter.Unsubscribe<string>(this, "ISVoterVotingUS");
        }
       // protected void override OnDisappearing() => 
    }
}