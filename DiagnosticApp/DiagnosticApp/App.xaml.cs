using DataBase.Repositories;
using Models;
using System;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DiagnosticApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var page = new WelcomePage.MainWelcomePage();
            NavigationPage.SetHasNavigationBar(page, false);
            MainPage = new NavigationPage(page);
        }

        protected override async void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
