﻿using System;
using System.Diagnostics;
using DI.Mediator.Abstracts;

namespace DI.Mediator.ConcreteParticipants
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

        public override void Receive(string from, string message)
        {
            Debug.Write("To a non-Beatle: ");
            base.Receive(from, message);
        }
    }
}