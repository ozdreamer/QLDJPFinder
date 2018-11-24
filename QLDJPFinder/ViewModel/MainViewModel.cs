using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

using Acr.UserDialogs;
using QLDJPFinder.Core;
using Xamarin.Forms;

namespace QLDJPFinder.UI
{
    public class MainViewModel
    {
        public INavigation Navigation { get; set; }

        public ICommand SearchCommand { get; set; }

        public JPFinderAPI finder;

        public IUserDialogs Dialog => UserDialogs.Instance;

        public string Area { get; set; }

        private IEnumerable<JPInfo> locations;

        public MainViewModel()
        {
            this.finder = new JPFinderAPI();
            this.SearchCommand = new Command(this.PerformSearch);
        }

        public async void PerformSearch()
        {
            this.Dialog.ShowLoading("Searching");
            this.locations = await this.finder.GetJPList(this.Area, 5);
            this.Dialog.HideLoading();

            if (!this.locations.Any())
            {
                this.Dialog.Alert("No record found.");
                return;
            }

            await this.Navigation.PushAsync(new LocationsPage(this.locations));
        }
    }
}
