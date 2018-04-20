using DI.WPF.One.Mediators;
using System.ComponentModel;
using System.Diagnostics;
using DI.WPF.One.Model;

namespace DI.WPF.One.Interfaces
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        #region Property Changed Event Handler
        public void SetPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion Property Changed Event Handler

        #region Field and Properties Mediator

        // Gets ViemModel name
        protected string _name;
        public string Name
        {
            get { return _name; }
        }

        protected ViewModelMediator _mediator;
        //By Constructor
        //public ViewModelBase(ViewModelMediator mediator)
        //{
        //    this._mediator = mediator;
        //}

        //By Property
        public ViewModelMediator Mediator
        {
            set { this._mediator = value; }
            get { return this._mediator; }
        }

        // Sends message to given participant
        public virtual void Send(string to, Customer customer)
        {
            _mediator.Send(to, customer);
        }

        
        public void Send(string to, string message)
        {
            _mediator.Send(_name, to, message);
        }

        // Receives message from given ViewModel
        public virtual void Receive(
            string from, string message)
        {
            Debug.WriteLine("{0} to {1}: '{2}'", from, Name, message);
        }
        #endregion

       
    }
}