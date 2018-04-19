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

        public CustomerListViewModel(ICustomerRepository customerRepository)
        {
            _customerObjCollection = new ObservableCollection<Customer>(customerRepository.GetAll());

        }

        //private Action<Customer> SetFileObjectCollection()
        //{
        //    this._fileObjectCollection = new ObservableCollection<FileObject>();
        //    return f => this._fileObjectCollection.Add(new FileObject { FileName = f.Name, Location = f.DirectoryName });
        //}


    }
}
