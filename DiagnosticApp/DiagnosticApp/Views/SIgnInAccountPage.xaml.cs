using DiagnosticApp.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DiagnosticApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SIgnInAccountPage : ContentPage
    {
        public SIgnInAccountPage()
        {
            InitializeComponent();
            BindingContext = new AccountViewModel();
        }
    }
}