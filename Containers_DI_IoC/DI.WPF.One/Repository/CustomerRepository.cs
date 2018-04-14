using DI.WPF.One.Model;
using System.Collections.Generic;
using System.Linq;

namespace DI.WPF.One.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        Customer ICustomerRepository.GetById(int p)
        {
            var lstCustomer = new List<Customer>
            {
                new Customer {Id = 1, Name = "Mark", Address = "Lisbon"},
                new Customer {Id = 1, Name = "Mark", Address = "England"}
            };
            return lstCustomer.FirstOrDefault(t => t.Id == p);
        }


        List<Customer> ICustomerRepository.GetAll()
        {
            var lstCustomer = new List<Customer>
            {
                new Customer {Id = 1, Name = "Mark", Address = "Lisbon"},
                new Customer {Id = 1, Name = "Mark", Address = "England"}
            };
            return lstCustomer;
        }
    }
}
