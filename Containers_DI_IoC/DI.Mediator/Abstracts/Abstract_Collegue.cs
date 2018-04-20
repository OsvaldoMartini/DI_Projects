using DI.Mediator.Mediators;

namespace DI.Mediator.Abstracts
{
    /// <summary>

    /// The 'Colleague' abstract class

    /// </summary>

    abstract class Abstract_Collegue
    {
        protected AMediatorColleagues mediator;

        // Constructor

        public Abstract_Collegue(AMediatorColleagues mediator)
        {
            this.mediator = mediator;
        }

    }
}