using RPSClinicalApp.Helpers;
using RPSClinicalApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RPSClinicalApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OPDPage : ContentPage
    {
        public OPDPage()
        {
            InitializeComponent();
            LoadData();
        }
        private async void LoadData()
        {
            ObservableCollection<MedicalCollege> MedicalColleges = 
                await new APIService().RefreshAsyncData();
            MedicalCollegeList.ItemsSource = MedicalColleges;
        }
    }
}