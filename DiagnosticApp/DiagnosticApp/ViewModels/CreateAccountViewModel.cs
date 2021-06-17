﻿using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace DiagnosticApp.ViewModels
{
    public class CreateAccountViewModel
    { 
        public ICommand CreateAccountCommand { protected set; get; }
        public CreateAccountViewModel()
        {
            CreateAccountCommand = new Command(CreateAccount);
        }
        private void CreateAccount(object accountObject)
        {
            AccountViewModel account = accountObject as AccountViewModel;
            if (account != null && account.IsNullloginAndPas)
            {
                if (account.Password == account.ConfirmPassword)
                {
                    account.ConfirmPassword = "";
                }
                else
                {
                    Application.Current.MainPage.DisplayAlert("Ошибка", "Пароли не совпадают", "ОК");
                }
            }
            else
            {
                Application.Current.MainPage.DisplayAlert("Ошибка", "Все поля должны быть заполнены", "ОК");
            }
        }
    }
}
