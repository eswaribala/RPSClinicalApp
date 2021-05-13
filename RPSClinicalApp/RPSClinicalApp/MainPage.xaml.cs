using RPSClinicalApp.Helpers;
using RPSClinicalApp.Themes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RPSClinicalApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            IPAddress.Text = DependencyService.Get<INetService>().ConvertHostIP();
            themePicker.SelectedIndexChanged += ThemePicker_SelectedIndexChanged;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await Task.Delay(10000);
            await this.Navigation.PushAsync(new LoginPage());

        }
        private void ThemePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            ThemeManager.ChangeTheme(themePicker.SelectedItem.ToString());
        }
    }
}
