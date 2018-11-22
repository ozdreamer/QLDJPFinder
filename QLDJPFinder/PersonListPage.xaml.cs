using System.Collections.Generic;
using QLDJPFinder.Core;
using Xamarin.Forms;

namespace QLDJPFinder
{
    public partial class PersonListPage : ContentPage
    {
        public PersonListPage(IEnumerable<JPInfo> jpInfo)
        {
            this.BindingContext = new PersonListViewModel(jpInfo);
            InitializeComponent();
        }
    }
}
