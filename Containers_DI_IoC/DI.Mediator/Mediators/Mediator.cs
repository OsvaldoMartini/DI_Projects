using DI_Mediator.Abstracts;

namespace DI_Mediator.Mediators
{

    /// <summary>

    /// The 'Mediator' abstract class

    /// </summary>

    abstract class Mediator
    {
        //Abstractions for Collegues Stories
        public abstract void Send(string message, Abstract_Collegue colleague);


    }
}