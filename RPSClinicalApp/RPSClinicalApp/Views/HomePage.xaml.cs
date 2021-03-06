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
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void OPD_Tapped(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new OPDPage());
        }
        private void ICU_Tapped(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new ICUPage());
        }
        private void XRAY_Tapped(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new XRayPage());
        }
        private void Pharmacy_Tapped(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new PharmacyPage());
        }

        private void BloodBank_Tapped(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new BloodBankPage());
        }
        private void Surgery_Tapped(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new SurgeryPage());
        }
        private void Account_Tapped(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new AccountPage());
        }
        private void Reception_Tapped(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new ReceptionPage());
        }
    }
}