using GuiaGuanajuato.Views;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GuiaGuanajuato
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected async override void OnStart()
        {
            var registrado = await SecureStorage.GetAsync("registrado");
            if (registrado == "si")
            {
                MainPage = new NavigationPage(new MenuAPI());
            }
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
