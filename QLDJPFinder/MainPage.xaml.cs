using Xamarin.Forms;

namespace QLDJPFinder.UI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            this.BindingContext = new MainViewModel { Navigation = Navigation };
            this.InitializeComponent();
        }
    }
}
