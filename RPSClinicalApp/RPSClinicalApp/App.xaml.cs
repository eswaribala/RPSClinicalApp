using RPSClinicalApp.Themes;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RPSClinicalApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            ThemeManager.ChangeTheme("Default");
            MainPage = new NavigationPage(new MainPage());
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
