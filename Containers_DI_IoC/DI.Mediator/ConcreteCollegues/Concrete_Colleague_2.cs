using System.Diagnostics;
using DI_Mediator.Abstracts;
using DI_Mediator.Mediators;

namespace DI_Mediator.ConcreteCollegues
{
    /// <summary>

    /// A 'Concrete Colleague 2' class

    /// </summary>

    class Concrete_Colleague_2 : Abstract_Collegue
    {
        // Constructor

        public Concrete_Colleague_2(Mediator mediator): base(mediator)
        {
        }

        public void Send(string message)
        {
            mediator.Send(message, this);
        }

        //Concrete Mediator Calls the Receiver via 
        //override Send
        public void Notify(string message)
        {
            Debug.WriteLine("Colleague2 gets message: " + message);
        }
    }
}