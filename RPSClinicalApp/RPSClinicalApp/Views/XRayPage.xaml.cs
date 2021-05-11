using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RPSClinicalApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class XRayPage : ContentPage
    {
        String PhotoPath = null;
        public XRayPage()
        {
            InitializeComponent();
        }

        private async void Camera_Pressed(object sender, EventArgs e)
        {
            await TakePhotoAsync();
            ShootedImage.Source = PhotoPath;
        }

        
        async Task TakePhotoAsync()
        {
            try
            {
                var mpo = new MediaPickerOptions()
                {
                    Title = "Shoot"
                };
                var photo = await MediaPicker.CapturePhotoAsync();
                await LoadPhotoAsync(photo);
                Console.WriteLine($"Capture Photo Completed", PhotoPath);
            }
            catch (Exception ex)
            {

            }
        }

        async Task LoadPhotoAsync(FileResult Photo)
        {


            if (Photo != null)
            {


                var newFile = Path.Combine(FileSystem.CacheDirectory, Photo.FileName);
                using (var stream = await Photo.OpenReadAsync())
                using (var newStream = File.OpenWrite(newFile))
                    await stream.CopyToAsync(newStream);
                PhotoPath = newFile;
            }

        }
    }
}