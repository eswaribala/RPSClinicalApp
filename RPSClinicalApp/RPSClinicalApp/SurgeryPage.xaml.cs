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
    public partial class SurgeryPage : ContentPage
    {
        public SurgeryPage()
        {
            InitializeComponent();
        }

        private void SignUp_Clicked(object sender, EventArgs e)
        {
            Application.Current.Properties["Id"] = new Random().Next(100000);
            Application.Current.Properties["FirstName"] = FirstName.Text;
            Application.Current.Properties["LastName"] = LastName.Text;
            Application.Current.Properties["DOB"] = DOB.Date.ToString();
            Application.Current.Properties["Email"] =Email.Text;
            Application.Current.Properties["Phone"] = Phone.Text;
            DisplayAlert("Success", "All Values Saved", "OK");
        }

        private void Show_Clicked(object sender, EventArgs e)
        {
        }
    }
        
}