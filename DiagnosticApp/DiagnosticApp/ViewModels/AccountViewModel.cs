using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel;
using DiagnosticApp.Models;
using Xamarin.Forms;

namespace DiagnosticApp.ViewModels
{
    public class AccountViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private Account account;
        public INavigation Navigation { get; set; }

        public AccountViewModel()
        {
            account = new Account();
        }
        public string Name
        {
            get => account.Name;
            set
            {
                if (account.Name != value)
                {
                    account.Name = value;
                    OnPropertyChanged("Name");
                }
            }
        }
        public string Surname
        {
            get => account.Surname;
            set
            {
                if (account.Surname != value)
                {
                    account.Surname = value;
                    OnPropertyChanged("Surname");
                }
            }
        }
        public string Patronymic
        {
            get => account.Patronymic;
            set
            {
                if (account.Patronymic != value)
                {
                    account.Patronymic = value;
                    OnPropertyChanged("Patronymic");
                }
            }
        }
        public string Login
        {
            get => account.Login;
            set
            {
                if (account.Login != value)
                {
                    account.Login = value;
                    OnPropertyChanged("Login");
                }
            }
        }
        public string Password
        {
            get => account.Password;
            set
            {
                if (account.Password != value)
                {
                    account.Password = value;
                    OnPropertyChanged("Password");
                }
            }
        }
        public bool IsValid
        {
            get
            {
                return (!string.IsNullOrEmpty(Name.Trim())) ||
                    (!string.IsNullOrEmpty(Surname.Trim())) ||
                    (!string.IsNullOrEmpty(Patronymic.Trim())) ||
                    (!string.IsNullOrEmpty(Login.Trim())) ||
                    (!string.IsNullOrEmpty(Password.Trim()));
            }
        }
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
