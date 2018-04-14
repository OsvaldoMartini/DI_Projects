using DI.WPF.One.Model;
namespace DI.WPF.One.Interfaces
{
    public interface ICustomerViewModel :IViewModel
    {
        Customer CustomerSelected { get; }
    }
}
