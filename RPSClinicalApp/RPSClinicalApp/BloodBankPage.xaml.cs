using RPSClinicalApp.ViewModels;
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
    public partial class BloodBankPage : ContentPage
    {
        public BloodBankPage()
        {
            InitializeComponent();
            var vm = new BloodBankViewModel();
            this.BindingContext = vm;
        }
    }
}