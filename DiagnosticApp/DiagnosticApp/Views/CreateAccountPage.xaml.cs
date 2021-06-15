using DiagnosticApp.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DiagnosticApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateAccountPage : ContentPage
    {
        public CreateAccountPage()
        {
            InitializeComponent();
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromHex("#000040");
            ((NavigationPage)Application.Current.MainPage).BarTextColor = Color.White;
            BindingContext = new AccountViewModel();
        }
    }
}