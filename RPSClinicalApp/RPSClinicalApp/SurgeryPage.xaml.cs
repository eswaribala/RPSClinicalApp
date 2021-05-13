using Plugin.FilePicker;
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

        private async void Browse_Clicked(object sender, EventArgs e)
        {
            try
            {
                string[] fileTypes = null;
                if (Device.RuntimePlatform == Device.iOS)
                {
                    fileTypes = new string[] { "com.adobe.pdf", "public.rft", "com.microsoft.word.doc", "org.openxmlformats.wordprocessingml.document" };
                }
                await PickAndShow(fileTypes);
            }
            catch (Exception ex)
            {

            }
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


        private async Task PickAndShow(string[] fileTypes)
        {
            try
            {

                var pickedFile = await CrossFilePicker.Current.PickFile(fileTypes);
                if (pickedFile != null)
                {
                    lblName.Text = pickedFile.FileName;
                    lblFilePath.Text = pickedFile.FilePath;
                    if (pickedFile.FileName.EndsWith("jpg", StringComparison.OrdinalIgnoreCase) ||
                pickedFile.FileName.EndsWith("png", StringComparison.OrdinalIgnoreCase))
                    {
                        var stream = pickedFile.GetStream();
                        ImageData.Source = ImageSource.FromStream(() => stream);
                    }


                }
            }
            catch (Exception ex)
            {

            }
        }
    }
        
}