using System.Collections.ObjectModel;
using DI.WPF.One.Model;

namespace DI.WPF.One.Interfaces
{
    public interface ICustomerListViewModel : IViewModel
    {
        ObservableCollection<Customer> CustomerObjCollection { get; }
    }
}
