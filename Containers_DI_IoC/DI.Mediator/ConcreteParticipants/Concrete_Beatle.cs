using System;
using System.Diagnostics;
using DI.Mediator.Abstracts;

namespace DI.Mediator.ConcreteParticipants
{
    /// <summary>

    /// A 'Concrete Participant' class

    /// </summary>

    class Concrete_Beatle : Abstract_Participant

    {
        // Constructor

        public Concrete_Beatle(string name): base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Debug.Write("To a Beatle: ");
            base.Receive(from, message);
        }
    }
}