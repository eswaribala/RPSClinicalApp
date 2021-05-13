using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RPSClinicalApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReceptionPage : ContentPage
    {
        public ReceptionPage()
        {
            InitializeComponent();
            if (Application.Current.Properties.ContainsKey("Id"))
            {
                FirstName.Text = Application.Current.Properties["FirstName"].ToString();
                LastName.Text = Application.Current.Properties["LastName"].ToString();
                DOB.Text = Application.Current.Properties["DOB"].ToString();
                Email.Text = Application.Current.Properties["Email"].ToString();
                Phone.Text = Application.Current.Properties["Phone"].ToString();

            }
        }

        private async void Share_Clicked(object sender, EventArgs e)
        {

            await ShareText("Hi");
        }
        public async Task ShareText(string text)
        {
            await Share.RequestAsync(new ShareTextRequest
            {
                Text = text,
                Title = "Share Text"
            });
        }
    }
}