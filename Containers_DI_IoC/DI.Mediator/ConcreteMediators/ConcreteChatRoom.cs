﻿using System.Collections.Generic;
using DI_Mediator.Abstracts;
using DI_Mediator.Mediators;

namespace DI_Mediator.ConcreteMediators
{
    /// <summary>

    /// The 'ConcreteMediator' class

    /// </summary>
    class ConcreteChatRoom : MediatorChat
    {
        private Dictionary<string, Abstract_Participant> _participants = new Dictionary<string, Abstract_Participant>();

        public override void Register(Abstract_Participant participant)
        {
            if (!_participants.ContainsValue(participant))
            {
                _participants[participant.Name] = participant;
            }

            participant.Chatroom = this;
        }

        public override void Send(string from, string to, string message)
        {
            Abstract_Participant participant = _participants[to];

            if (participant != null)
            {
                participant.Receive(from, message);
            }
        }
    }
}