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
    public partial class AddContact : Rg.Plugins.Popup.Pages.PopupPage
    {
        public AddContact()
        {
            InitializeComponent();
        }
        private void btnSaveClicked(object sender, EventArgs e)
        {
            MessagingCenter.Send<string>("OURS", "ISVoterVotingUS");
        }
        private void btnCancelClicked(object sender, EventArgs e)
        {
            MessagingCenter.Send<string>("OURS", "ISVoterVotingUS");
        }
    }
}