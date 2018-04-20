using System.Collections.ObjectModel;
using DI.WPF.One.Interfaces;
using DI.WPF.One.Model;
using DI.WPF.One.Repository;

namespace DI.WPF.One.ViewModel

{
    public class CustomerListViewModel : ViewModelBase, ICustomerListViewModel
    {
        private ObservableCollection<Customer> _customerObjCollection;
        public ObservableCollection<Customer> CustomerObjCollection
        {
            get { return _customerObjCollection; }
            set
            {
                if (value != this._customerObjCollection)
                    _customerObjCollection = value;
                this.SetPropertyChanged("CustomerObjCollection");
            }
        }

        private Customer _selectedCustomerObject;
        public Customer SelectedCustomerObject
        {

            //Esta propriedade deve ser sincronizada com CustomerViewModel
            //Talvez por "Messager" ou Mediator

            get { return _selectedCustomerObject; }
            set
            {
                if (value != this._selectedCustomerObject)
                    _selectedCustomerObject = value;
                this.SetPropertyChanged("SelectedCustomerObject");
            }
        }
        public CustomerListViewModel(ICustomerRepository customerRepository)
        {

            _customerObjCollection = new ObservableCollection<Customer>(customerRepository.GetAll());

        }

       
    }
}
