using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ElectionMobileApp.ViewModels
{
    public class ListPageViewModel : BaseViewModel
    {
        public Command LoadItemsCommand { get; set; }
        public ObservableCollection<string> Items { get; set; }
        public ListPageViewModel()
        {
            Title = "Lists";
            Items = new ObservableCollection<string>();

            Items.Add("Advance Search");
            Items.Add("By Village");
            Items.Add("By Part No");
            Items.Add("By Address");
            Items.Add("By Booth");
            Items.Add("By Color");
            Items.Add("By Cast");
            Items.Add("By Age");
            Items.Add("By Profession");
            Items.Add("Dead");
            Items.Add("Repeated");
            Items.Add("Mobile Number");
            Items.Add("Voted");
            Items.Add("By New Address");
            Items.Add("By Society");
            //LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
            
        }
    }
    public enum ListBy
    {
        [Description("Advance Search")]
        Advance_Search,
        [Description("By Village")]
        By_Village,
        [Description("By Part No")]
        By_PartNumber,
        [Description("By Address")]
        By_Address,
        [Description("By Booth")]
        By_Booth,
        [Description("By Color")]
        By_Color,
        [Description("By Age")]
        By_Age,
        [Description("By Cast")]
        By_Cast,
        [Description("By Profession")]
        By_Profession,
        [Description("Dead")]
        By_Dead,
        [Description("Repeated")]
        By_Repeated,
        [Description("Important Voters")]
        By_ImportantVoters,
        [Description("Mobile Number")]
        By_MobileNumber,
        [Description("Voted")]
        By_Voted,
        [Description("By New Address")]
        By_NewAddress,
        [Description("By Society")]
        By_Society,
    }
}
