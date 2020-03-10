using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using ElectionMobileApp.Models;
using ElectionMobileApp.Services;
using ElectionMobileApp.Views;
using Xamarin.Forms;
using VoterInformation = ElectionMobileApp.Models.VoterInformation;

namespace ElectionMobileApp.ViewModels
{
    public class VoterInformationViewModel : BaseViewModel
    {
        public IDataStore<VoterInformation> DataStore => DependencyService.Get<IDataStore<VoterInformation>>() ?? new VoterDetailsMockDataStore();
        public ObservableCollection<VoterInformation> Items { get; set; }
        public Command LoadItemsCommand { get; set; }

        public VoterInformationViewModel()
        {
            Title = "Voter Info";
            Items = new ObservableCollection<VoterInformation>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;
            try
            {
                Items.Clear();
                var items = await DataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                   Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}