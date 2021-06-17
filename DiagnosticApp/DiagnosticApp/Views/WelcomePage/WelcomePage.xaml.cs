using DiagnosticApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace DiagnosticApp.WelcomePage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private async void OnAuthorizationButtonClicked(object sender, System.EventArgs e)
        {
            bool result = await DisplayAlert("У вас уже есть аккаунт?", "", "Нет", "Да");
            if (result)
                _ = Navigation.PushAsync(new CreateAccountPage(new ViewModels.AccountViewModel() { CreateViewModel = new ViewModels.CreateAccountViewModel() }));
            else
                _ = Navigation.PushAsync(new SIgnInAccountPage());
        }
    }
}