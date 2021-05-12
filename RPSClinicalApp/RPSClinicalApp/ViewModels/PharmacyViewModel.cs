using RPSClinicalApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace RPSClinicalApp.ViewModels
{
    public class PharmacyViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<Medicine> _Medicines;
        private String _pageTitle,_description;
        public PharmacyViewModel()
        {
            _pageTitle = "Covid 19 Medicines";
            _description = "Tablets and Vaccines Available for recovery";
            _Medicines = new ObservableCollection<Medicine>();
            _Medicines.Add(new Medicine { Title = "Tablet", ImagePath = "one.jpg", Description = "Covid Tablet" });
            _Medicines.Add(new Medicine { Title = "Tablet", ImagePath = "two.jpg", Description = "Covid Tablet" });
            _Medicines.Add(new Medicine { Title = "Tablet", ImagePath = "three.jpg", Description = "Covid Tablet" });
            _Medicines.Add(new Medicine { Title = "Vaccine", ImagePath = "four.jpg", Description = "Covid Tablet" });
            _Medicines.Add(new Medicine { Title = "Vaccine", ImagePath = "five.jpg", Description = "Covid Tablet" });

        }

        public ObservableCollection<Medicine> Medicines
        {
            get
            {
                return _Medicines;
            }
            set
            {
                if (_Medicines != value)
                {
                    _Medicines = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Medicines"));
                }
            }


        }

        public string Title
        {
            get
            {
                return _pageTitle;
            }
            set
            {
                if (_pageTitle != value)
                {
                    _pageTitle = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Title"));
                }
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                if (_description != value)
                {
                    _description = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Description"));
                }
            }
        }

        private void OnPropertyChanged(PropertyChangedEventArgs eventArgs)
        {
            PropertyChanged?.Invoke(this, eventArgs);
        }
    }
}
