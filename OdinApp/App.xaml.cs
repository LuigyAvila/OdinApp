using OdinApp.Views;
using OdinApp.Views.IntroTutorial;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OdinApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CreateAccount();
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
