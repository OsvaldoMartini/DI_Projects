using DI_Mediator.Mediators;

namespace DI_Mediator.Abstracts
{
    /// <summary>

    /// The 'Colleague' abstract class

    /// </summary>

    abstract class Abstract_Collegue
    {
        protected Mediator mediator;

        // Constructor

        public Abstract_Collegue(Mediator mediator)
        {
            this.mediator = mediator;
        }

    }
}