using System;
using System.Diagnostics;
using DI.Mediator.Abstracts;
using DI.Mediator.Mediators;

namespace DI.Mediator.ConcreteCollegues
{
    /// <summary>

    /// A 'Concrete Colleague 2' class

    /// </summary>

    class Concrete_Colleague_2 : Abstract_Collegue
    {
        // Constructor

        public Concrete_Colleague_2(AbstractMediator mediator): base(mediator)
        {
        }

        public void Send(string message)
        {
            mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Debug.WriteLine("Colleague2 gets message: " + message);
        }
    }
}