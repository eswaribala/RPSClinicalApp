using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RPSClinicalApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ICUPage : ContentPage
    {
        NetworkAccess current;
        IEnumerable<ConnectionProfile> profiles;
        SensorSpeed _sensorSpeed = SensorSpeed.UI;
        public ICUPage()
        {
            InitializeComponent();
                current = Connectivity.NetworkAccess;
            profiles = Connectivity.ConnectionProfiles;
            // Register for connectivity changes, be sure to unsubscribe when finished
            Connectivity.ConnectivityChanged += Connectivity_ConnectivityChanged;
            if (current == NetworkAccess.Internet)
            {
                lblNetworkStatus.Text = "Network is Available";
            }
            else
            {
                lblNetworkStatus.Text = "Network is Not Available";
            }

            if (profiles.Contains(ConnectionProfile.WiFi))
            {
                lblNetworkProfile.Text = profiles.FirstOrDefault().ToString();
            }
            else
            {
                lblNetworkProfile.Text = profiles.FirstOrDefault().ToString();
            }
            Compass.ReadingChanged += Compass_ReadingChanged;
            Compass.Start(_sensorSpeed);
        }
        private void Compass_ReadingChanged(object sender, CompassChangedEventArgs e)
        {
            var data = e.Reading;
            Patient.Rotation = Convert.ToDouble(-1 * data.HeadingMagneticNorth);
        }

        void Connectivity_ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        {
            current = e.NetworkAccess;
            profiles = e.ConnectionProfiles;
        }
    }
}