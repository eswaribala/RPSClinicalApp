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
       
        SensorSpeed _sensorSpeed = SensorSpeed.UI;
        public ICUPage()
        {
            InitializeComponent();
               
            Compass.ReadingChanged += Compass_ReadingChanged;
            Compass.Start(_sensorSpeed);
           
        }
        private void Compass_ReadingChanged(object sender, CompassChangedEventArgs e)
        {
            var data = e.Reading;
            Patient.Rotation = Convert.ToDouble(-1 * data.HeadingMagneticNorth);
        }

        
    }
}