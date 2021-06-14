using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DiagnosticApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new WelcomePage.MainWelcomePage();
        }

        protected override void OnStart()
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
