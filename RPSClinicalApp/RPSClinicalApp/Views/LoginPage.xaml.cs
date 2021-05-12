using RPSClinicalApp.ViewModels;
using RPSClinicalApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RPSClinicalApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
           
            //themePicker.SelectedIndexChanged += ThemePicker_SelectedIndexChanged;
            var vm = new LoginViewModel();
            this.BindingContext = vm;
            vm.InvalidLoginPrompt += () => DisplayAlert("Error", "Invalid Login, try again", "OK");
            vm.ValidLoginPrompt += () =>
            {
                this.Navigation.PushAsync(new HomePage());
            };

           // InitializeComponent();
            Email.Completed += (object sender, EventArgs e) =>
            {
                Password.Focus();
            };

            Password.Completed += (object sender, EventArgs e) =>
            {
                vm.SubmitCommand.Execute(null);
            };
        }
        
        
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new RegistrationPage());
        }
    }
}