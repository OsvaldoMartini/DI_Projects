using DI.WPF.One.Interfaces;
using DI.WPF.One.Model;
using DI.WPF.One.Repository;

namespace DI.WPF.One.ViewModel
{
    public class CustomerViewModel:ViewModelBase,ICustomerViewModel
    {

        private Customer _CustomerSelected;
        public Customer CustomerObjSelected
        {
            get { return _CustomerSelected; }
            set
            {
                if (value != this._CustomerSelected)
                    _CustomerSelected = value;
                this.SetPropertyChanged("CustomerObjSelected");
            }
        }

        public CustomerViewModel()
        {
            //_CustomerModel.Id= 0;
            //_CustomerModel.Name=
            //    _CustomerModel.Address= null;
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
                SetPropertyChanged("CustomerId");
            }
        }
        public string CustomerName
        {
            get { return _CustomerSelected.Name; }
            set
            {
                _CustomerSelected.Name = value;
                SetPropertyChanged("CustomerName");
            }
        }

        public string CustomerAddress
        {
            get { return _CustomerSelected.Address; }
            set
            {
                _CustomerSelected.Address = value;
                SetPropertyChanged("CustomerAddress");
            }
        }


      
    }
}
