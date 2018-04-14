using System.Collections.ObjectModel;
using DI.WPF.One.Interfaces;
using DI.WPF.One.Model;
using DI.WPF.One.Repository;

namespace DI.WPF.One.ViewModel

{
    public class CustomerListViewModel : ViewModelBase, ICustomerListViewModel
    {
   
        private ObservableCollection<Customer> _customerObjectCollection;
        public ObservableCollection<Customer> CustomerObjectCollection
        {
            get { return _customerObjectCollection; }
            set
            {
                if (value != this._customerObjectCollection)
                    _customerObjectCollection = value;
                this.SetPropertyChanged("CustomerObjectCollection");
            }
        }

        public CustomerListViewModel(ICustomerRepository customerRepository)
        {
            _customerObjectCollection = new ObservableCollection<Customer>(customerRepository.GetAll());

        }

        //private Action<Customer> SetFileObjectCollection()
        //{
        //    this._fileObjectCollection = new ObservableCollection<FileObject>();
        //    return f => this._fileObjectCollection.Add(new FileObject { FileName = f.Name, Location = f.DirectoryName });
        //}


    }
}
