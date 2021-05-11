using RPSClinicalApp.Models;
using RPSClinicalApp.Persistence;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace RPSClinicalApp.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public Action InvalidLoginPrompt;
        public Action ValidLoginPrompt;
        private SQLiteConnection _SQLiteConnection;
        public event PropertyChangedEventHandler PropertyChanged=delegate { };
        private String email;
        private String password;
        public string Email { 
            get { return email; }
            set { 
                email = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Email"));
            }
        }
        public string Password
        {
            get
            { return password; }
            set
            {
                password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }

        }

        public ICommand SubmitCommand { protected set; get; }
        public LoginViewModel()
        {
            SubmitCommand = new Command(OnSubmit);
            //RegisterCommand = new Command(OnRegister);
        }
        public void OnSubmit()
        {
            _SQLiteConnection = DependencyService.Get<ISqliteDB>().GetSQLiteConnection();
            _SQLiteConnection.CreateTable<User>();
            if (!LoginValidate(email, password))
            {
                InvalidLoginPrompt();
            }
            else
            {
                ValidLoginPrompt();
            }
        }

        public bool LoginValidate(string email, string pwd)
        {
            var data = _SQLiteConnection.Table<User>();
            var d1 = data.Where(x => x.Email == email && x.Password == pwd).FirstOrDefault();

            if (d1 != null)
            {
                return true;
            }
            else
                return false;
        }
    }
}
