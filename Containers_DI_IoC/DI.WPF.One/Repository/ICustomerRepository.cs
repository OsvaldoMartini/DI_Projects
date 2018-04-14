using System.Collections.Generic;
using DI.WPF.One.Model;

namespace DI.WPF.One.Repository
{
    public interface ICustomerRepository
    {
        Customer GetById(int p);

        List<Customer> GetAll();

        
    }
}
