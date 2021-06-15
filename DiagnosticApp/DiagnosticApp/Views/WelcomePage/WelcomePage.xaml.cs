using DiagnosticApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DiagnosticApp.ViewModels;

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
            //await DisplayAlert("Уведомление", "Вы выбрали: "+ (result ? "Удалить" : "Отменить"), "OK");
            if (result)
                _ = Navigation.PushAsync(new CreateAccountPage());
            else
                _ = Navigation.PushAsync(new SIgnInAccountPage());
        }
    }
}