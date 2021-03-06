﻿using DI_Mediator.Abstracts;
using DI_Mediator.ConcreteCollegues;
using DI_Mediator.Mediators;

namespace DI_Mediator.ConcreteMediators
{
    /// <summary>

    /// The 'ConcreteMediator' class

    /// </summary>

    class ConcreteMediator : Mediator


    {
        private Concrete_Colleague_1 _colleague1;
        private Concrete_Colleague_2 _colleague2;
        public Concrete_Colleague_1 Colleague1
        {
            set { _colleague1 = value; }
        }

        public Concrete_Colleague_2 Colleague2
        {
            set { _colleague2 = value; }
        }

        public override void Send(string message, Abstract_Collegue colleague)
        {
            if (colleague == _colleague1)
            {
                _colleague2.Notify(message);
            }
            else

            {
                _colleague1.Notify(message);
            }
        }

    }
}