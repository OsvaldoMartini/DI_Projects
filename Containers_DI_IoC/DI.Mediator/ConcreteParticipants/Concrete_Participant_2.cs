using System.Diagnostics;
using DI_Mediator.Abstracts;

namespace DI_Mediator.ConcreteParticipants
{
    /// <summary>

    /// A 'Concrete Participant' class

    /// </summary>

    class Concrete_Participant_2 : Abstract_Participant
    {
        // Constructor

        public Concrete_Participant_2(string name): base(name)
        {
        }

        //Concrete Mediator Calls the Receiver via 
        //override and base
        public override void Receive(string from, string message)
        {
            Debug.Write("To a non-Beatle: ");
            base.Receive(from, message);
        }
    }
}
