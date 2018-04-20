using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.WPF.One.Interfaces;
using DI.WPF.One.Model;
using DI.WPF.One.ViewModel;

namespace DI.WPF.One.Mediators
{
    /// <summary>

    /// The 'ConcreteMediator' class

    /// </summary>
    public class ConcreteMediator : MediatorViewModel
    {
        private CustomerViewModel _CustomerViewModel;
        //private CustomerListViewModel _CustomerListViewModel;
        //public ICustomerViewModel CustomerViewModel
        //{
        //    get { return _CustomerViewModel; }
        //    set { _CustomerViewModel = value; }
        //}

        //public ICustomerListViewModel CustomerListViewModel
        //{
        //    get { return _CustomerListViewModel; }
        //    set { _CustomerListViewModel = value; }
        //}

        public ConcreteMediator(CustomerViewModel customerViewModel)
        {
            this._CustomerViewModel = customerViewModel;
        }

        public override void Send(string message, AbstractViewModel viewModel)
        {
            //throw new NotImplementedException();
        }

        public override void SendCustomer(string message, Customer customer)
        {
            //Call Reveice Client
            //if (_CustomerViewModel == viewModel)
            //{
           // _CustomerViewModel.Receiver(message, customer);
            //}
            //else
           // {
                //CustomerViewModel.Receiver(message, customer);

            //CustomerObjSelected}
            
        }

    }
}