using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.Mediator.Abstracts;

namespace DI.Mediator.Mediators
{
    abstract class AbstractChatMediator
    {
        //Abstractions for the Participants in a Chat Room Story
        public abstract void Register(Abstract_Participant participant);

        public abstract void Send(string from, string to, string message);
    }
}
