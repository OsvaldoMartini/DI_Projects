using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Controls;
using DI.WPF.One.Commons;
using DI.WPF.One.Interfaces;
using DI.WPF.One.MediatorVM;
using DI.WPF.One.Model;
using DI.WPF.One.Repository;

namespace DI.WPF.One.ViewModel
{
    public class CustomerViewModel: ViewModelBase,ICustomerViewModel
    {
        private Customer _CustomerSelected;
        public Customer CustomerObjSelected
        {
            get { return _CustomerSelected; }
            set
            {
                if (value != this._CustomerSelected)
                    _CustomerSelected = value;
                this.NotifyPropertyChanged(new PropertyChangedEventArgs("CustomerObjSelected"));
            }
        }

        public void Notify(string message)
        {
            Debug.WriteLine("ViewModel gets message: " + message);
        }

        public CustomerViewModel()
        {
        }
        public CustomerViewModel(ICustomerRepository customerRepository)
        {
            _CustomerSelected = customerRepository.GetById(1);

        }

        public int CustomerId
        {
            get { return _CustomerSelected.Id; }
            set
            {
                _CustomerSelected.Id = value;
                NotifyPropertyChanged(new PropertyChangedEventArgs("CustomerId"));
            }
        }
        public string CustomerName
        {
            get { return _CustomerSelected.Name; }
            set
            {
                _CustomerSelected.Name = value;
                NotifyPropertyChanged(new PropertyChangedEventArgs("CustomerName"));
            }
        }

        public string CustomerAddress
        {
            get { return _CustomerSelected.Address; }
            set
            {
                _CustomerSelected.Address = value;
                NotifyPropertyChanged(new PropertyChangedEventArgs("CustomerAddress"));
            }
        }


        private Customer _selectedCustomer;
        public Customer SelectedCustomer
        {
            get
            {
                return _selectedCustomer;
            }
            set
            {
                _selectedCustomer = value;
                NotifyPropertyChanged(new PropertyChangedEventArgs("SelectedCustomer"));
            }
        }


      
    }
}
