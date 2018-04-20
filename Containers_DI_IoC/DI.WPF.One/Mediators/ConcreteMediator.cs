using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.WPF.One.Interfaces;

namespace DI.WPF.One.Mediators
{
    /// <summary>

    /// The 'ConcreteMediator' class

    /// </summary>

    abstract class ConcreteMediator : MediatorViewModel
    {
        private IViewModel _CustomerViewModel;
        private IViewModel _CustomerListViewModel;
        public ICustomerViewModel CustomerViewModel
        {
            set { _CustomerViewModel = value; }
        }

        public ICustomerListViewModel CustomerListViewModel
        {
            set { _CustomerListViewModel = value; }
        }

        public override void Send(string message, AbstractViewModel customerView)
        {
            //if (colleague == _colleague1)
            //{
            //    _colleague2.Notify(message);
            //}
            //else
            //{
            //    _colleague1.Notify(message);
            //}
        }

    }
}