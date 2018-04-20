using DI.Mediator.Abstracts;

namespace DI.Mediator.Mediators
{
    /*
     *
     The classes and objects participating in this pattern are:
        Mediator  (IChatroom)
        defines an interface for communicating with Colleague objects
    ConcreteMediator  (Chatroom)
        implements cooperative behavior by coordinating Colleague objects
        knows and maintains its colleagues
    Colleague classes  (Participant)
        each Colleague class knows its Mediator object
        each colleague communicates with its mediator whenever it would have otherwise communicated with another colleague
     */


    /// <summary>
    ///  The 'Mediator' abstract class
    /// </summary>

    abstract class AMediatorChatRoom
    {
        //Abstractions for the Participants in a Chat Room Story
        public abstract void Register(Abstract_Participant participant);
        
        public abstract void Send(string from, string to, string message);


    }
}