using System;
using System.Diagnostics;
using DI.Mediator.Abstracts;
using DI.Mediator.ConcreteCollegues;
using DI.Mediator.ConcreteMediators;
using DI.Mediator.ConcreteParticipants;

namespace DI.Mediator.Business
{
    public class Communicator
    {
        public Communicator()
        {

            //Colleagues Mediator
            ConcreteMediator m = new ConcreteMediator();

            Concrete_Colleague_1 c1 = new Concrete_Colleague_1(m);
            Concrete_Colleague_2 c2 = new Concrete_Colleague_2(m);

            m.Colleague1 = c1;
            m.Colleague2 = c2;

            c1.Send("How are you?");
            c2.Send("Fine, thanks");

            // Wait for user

            Debug.WriteLine("");
            
            //Chat Room Mediator
            ConcreteChatRoom chatroom = new ConcreteChatRoom();
 
             //Create participants and register them

            Abstract_Participant George = new Concrete_Participant_1("George");
            Abstract_Participant Paul = new Concrete_Participant_1("Paul");
            Abstract_Participant Ringo = new Concrete_Participant_1("Ringo");
            Abstract_Participant John = new Concrete_Participant_1("John");
            Abstract_Participant Yoko = new Concrete_Participant_2("Yoko");
 
            chatroom.Register(George);
            chatroom.Register(Paul);    
            chatroom.Register(Ringo);
            chatroom.Register(John);
            chatroom.Register(Yoko);
 
            // Chatting participants

            Yoko.Send("John", "Hi John!");
            Paul.Send("Ringo", "All you need is love");
            Ringo.Send("George", "My sweet Lord");
            Paul.Send("John", "Can't buy me love");
            John.Send("Yoko", "My sweet love");
 
            // Wait for user

            Debug.WriteLine("");

        }

    }
}
