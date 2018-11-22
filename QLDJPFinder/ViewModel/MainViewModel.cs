using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Acr.UserDialogs;
using QLDJPFinder.Core;
using Xamarin.Forms;

namespace QLDJPFinder
{
    public class MainViewModel
    {
        public INavigation Navigation { get; set; }

        public ICommand SearchCommand { get; set; }

        public JPFinderAPI api;

        public IUserDialogs Dialog => UserDialogs.Instance;

        public string Area { get; set; }

        private IEnumerable<JPInfo> persons;

        public MainViewModel()
        {
            this.api = new JPFinderAPI();
            this.SearchCommand = new Command(this.PerformSearch);
        }

        public async void PerformSearch()
        {
            this.Dialog.ShowLoading("Searching");

            var allPersons = await this.api.GetJPList(this.Area, 5);
            var postCodeInt = int.Parse(this.Area);
            this.persons = allPersons.Where(x => x.PostCode == postCodeInt);

            this.Dialog.HideLoading();

            if (!this.persons.Any())
            {
                this.Dialog.Alert("No record found.");
                return;
            }

            await this.Navigation.PushAsync(new PersonListPage(this.persons));
        }
    }
}
