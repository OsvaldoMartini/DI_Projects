using System.Diagnostics;
using DI_Mediator.Abstracts;

namespace DI_Mediator.ConcreteParticipants
{
    /// <summary>

    /// A 'Concrete Participant' class

    /// </summary>

    class Concrete_Participant_1 : Abstract_Participant

    {
        // Constructor

        public Concrete_Participant_1(string name): base(name)
        {
        }

        //Concrete Mediator Calls the Receiver via 
        //override and base
        public override void Receive(string from, string message)
        {
            Debug.Write("To a Beatle: ");
            base.Receive(from, message);
        }
    }
}