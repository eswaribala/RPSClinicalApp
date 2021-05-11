using RPSClinicalApp.Models;
using RPSClinicalApp.Persistence;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RPSClinicalApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        private SQLiteConnection _SQLiteConnection;
        private int count;
        public RegistrationPage()
        {
            InitializeComponent();
            _SQLiteConnection = DependencyService.Get<ISqliteDB>().GetSQLiteConnection();
            _SQLiteConnection.CreateTable<User>();
        }

        private void SignUp_Clicked(object sender, EventArgs e)
        {
            var User = new User();
            User.FirstName = FirstName.Text;
            User.LastName = LastName.Text;
            User.Password = Password.Text;
            User.DOB = DOB.Date.ToString();
            User.Email = Email.Text;
            User.PhoneNo = Convert.ToInt64(Phone.Text);
           count= _SQLiteConnection.Insert(User);
            if (count > 0)
            {
                DisplayAlert("Registration", "Thanks for Registration", "Cancel");
            }
            else
            {
                DisplayAlert("Registration Failed!!!", "Please try again", "ERROR");
            }
        }

        private void Show_Clicked(object sender, EventArgs e)
        {

        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new LoginPage());
        }
    }
}