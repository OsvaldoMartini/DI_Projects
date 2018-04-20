using System;
using DI.Mediator.Abstracts;
using DI.Mediator.Mediators;
using System.Diagnostics;

namespace DI.Mediator.ConcreteCollegues
{
    /// <summary>

  /// A 'Concrete Colleague 1' class

  /// </summary>

    class Concrete_Colleague_1 : Abstract_Collegue

  {
    // Constructor

        public Concrete_Colleague_1(AMediatorColleagues mediator)
            : base(mediator)
    {
    }
 
    public void Send(string message)
    {
       mediator.Send(message, this);
    }
 
    public void Notify(string message)
    {
        Debug.WriteLine("Colleague1 gets message: "

        + message);
    }
  }
   
}
