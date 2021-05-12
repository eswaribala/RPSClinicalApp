using RPSClinicalApp.ViewModels;
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
    public partial class PharmacyPage : ContentPage
    {
        public PharmacyPage()
        {
            InitializeComponent();
            var vm = new PharmacyViewModel();
            this.BindingContext = vm;
        }
    }
}