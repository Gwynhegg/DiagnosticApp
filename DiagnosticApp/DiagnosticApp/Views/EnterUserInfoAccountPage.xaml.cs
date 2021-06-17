using DiagnosticApp.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DiagnosticApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EnterUserInfoAccountPage : ContentPage
    {
        public AccountViewModel ViewModel { get; private set; }
        public EnterUserInfoAccountPage(AccountViewModel vm)
        {
            InitializeComponent();
            ViewModel = vm;
            BindingContext = ViewModel;
        }
        private void OnSexRadioButtonCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            var check = (RadioButton)sender;
            ViewModel.Sex = (string)check.Content;
        }
    }
}