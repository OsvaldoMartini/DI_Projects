using DI.Mediator.Abstracts;

namespace DI.Mediator.Mediators
{

    /// <summary>

    /// The 'Mediator' abstract class

    /// </summary>

    abstract class AMediatorColleagues
    {
        //Abstractions for Collegues Stories
        public abstract void Send(string message, Abstract_Collegue colleague);

    }
}