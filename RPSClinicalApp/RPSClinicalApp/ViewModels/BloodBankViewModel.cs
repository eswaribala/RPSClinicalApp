using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace RPSClinicalApp.ViewModels
{
    public class BloodBankViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
     

        private string _conn;
        public string Conn
        {
            get => _conn;
            set
            {
                _conn = value;
                OnPropertyChanged();
            }
        }

        public BloodBankViewModel()
        {
            CheckWifiOnStart();
            CheckWifiContinuously();
        }

        public void CheckWifiOnStart()
        {
            Conn = CrossConnectivity.Current.IsConnected ? "online.png" : "offline.png";
        }

        public void CheckWifiContinuously()
        {
            CrossConnectivity.Current.ConnectivityChanged += (sender, args) =>
            {
                Conn = args.IsConnected ? "online.png" : "offline.png";
            };
        }



        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
