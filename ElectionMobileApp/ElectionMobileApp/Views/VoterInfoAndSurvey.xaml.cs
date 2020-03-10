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
    public partial class VoterInfoAndSurvey : TabbedPage
    {
        
        public VoterInfoAndSurvey (VoterInformation data)
        {

            this.Title = "";
            this.Children.Add(new VoterInformationPage(data));
            this.Children.Add(new SurveyViews.VoterSurveyPage(data));
        }
        public VoterInfoAndSurvey()
        {


            InitializeComponent();


        }
    }
}