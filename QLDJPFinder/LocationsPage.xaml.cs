using System.Collections.Generic;
using QLDJPFinder.Core;
using Xamarin.Forms;

namespace QLDJPFinder.UI
{
    public partial class LocationsPage : ContentPage
    {
        public LocationsPage(IEnumerable<JPInfo> jpInfo)
        {
            this.BindingContext = new LocationsViewModel(jpInfo);
            this.InitializeComponent();
        }
    }
}
