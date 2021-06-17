using DiagnosticApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DiagnosticApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateAccountPage : ContentPage
    {
        public AccountViewModel ViewModel { get; private set; }
        public CreateAccountPage(AccountViewModel vm)
        {
            InitializeComponent();
            ViewModel = vm;
            BindingContext = ViewModel;
        }
    }
}