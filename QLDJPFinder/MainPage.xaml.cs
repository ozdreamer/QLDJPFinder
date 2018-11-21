using Xamarin.Forms;

namespace QLDJPFinder
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            this.BindingContext = new MainViewModel { Navigation = Navigation };
            InitializeComponent();
        }
    }
}
