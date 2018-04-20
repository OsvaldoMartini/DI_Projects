using DI_Mediator.Abstracts;

namespace DI_Mediator.Mediators
{
    abstract class MediatorChat
    {
        //Abstractions for the Participants in a Chat Room Story
        public abstract void Register(Abstract_Participant participant);

        public abstract void Send(string from, string to, string message);
    }
}
