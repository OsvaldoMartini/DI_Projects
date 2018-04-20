using DI.Mediator.Mediators;

namespace DI.Mediator.Abstracts
{
    /// <summary>

    /// The 'Colleague' abstract class

    /// </summary>

    abstract class Abstract_Collegue
    {
        protected AbstractMediator mediator;

        // Constructor

        public Abstract_Collegue(AbstractMediator mediator)
        {
            this.mediator = mediator;
        }

    }
}