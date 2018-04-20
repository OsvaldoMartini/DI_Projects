using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.WPF.One.Model;

namespace DI.WPF.One.Mediators
{
    /// <summary>

    /// The 'Colleague' abstract class

    /// </summary>

    abstract class AbstractViewModel
    {
        
        // Gets ViemModel name
        private string _name;
        public string Name
        {
            get { return _name; }
        }

        protected MediatorViewModel _mediator;
        //By Constructor
        //public ViewModelBase(ViewModelMediator mediator)
        //{
        //    this._mediator = mediator;
        //}

        //By Property
        public MediatorViewModel Mediator
        {
            set { this._mediator = value; }
            get { return this._mediator; }
        }

        // Sends message to given participant
        //public virtual void Send(string to, Customer customer)
        //{
        //    _mediator.Send(to, customer);
        //}


        //public void Send(string to, string message)
        //{
        //    _mediator.Send(_name, to, message);
        //}

        public virtual void Send(string message, AbstractViewModel viewModel)
        {
             _mediator.Send(message, viewModel);
        }

        // Receives message from given ViewModel
        public virtual void Receive(
            string from, string message)
        {
            Debug.WriteLine("{0} to {1}: '{2}'", from, Name, message);
        }
 
    }
}