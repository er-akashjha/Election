using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ElectionMobileApp.Views.ModalPOPUP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IsHeVotingUS : Rg.Plugins.Popup.Pages.PopupPage
    {
       
        public IsHeVotingUS()
        {
            InitializeComponent();
          
        }
        private void btnClicked(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;
                switch (btn.Text)
                {
                    case "OURS":
                        {
                            MessagingCenter.Send<string>("OURS", "ISVoterVotingUS");
                            break;
                        }
                    case "OPPOSITE":
                        {
                            MessagingCenter.Send<string>("OPPOSITE", "ISVoterVotingUS");
                            break;
                        }
                    case "DOUBTFUL":
                        {
                            MessagingCenter.Send<string>("DOUBTFUL", "ISVoterVotingUS");
                            break;
                        }
                    case "OTHER":
                        {
                            MessagingCenter.Send<string>("OTHER", "ISVoterVotingUS");
                            break;
                        }
                }
                Navigation.PopPopupAsync();
            }
            catch(Exception er)
            {

            }
        }

        //protected override bool OnBackButtonPressed()
        //{
        //    // Return true if you don't want to close this popup page when a back button is pressed
        //    return base.OnBackButtonPressed();
        //}
        //protected override bool OnBackgroundClicked()
        //{
        //    // Return false if you don't want to close this popup page when a background of the popup page is clicked
        //    return base.OnBackgroundClicked();
        //}
    }
}