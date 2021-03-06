﻿using System.Diagnostics;
using DI_Mediator.Mediators;

namespace DI_Mediator.Abstracts
{
    /// <summary>

    /// The 'Participant' class

    /// </summary>

    abstract class Abstract_Participant
    {
        protected MediatorChat _chatroom;
        private string _name;

        public Abstract_Participant(string name)
        {
            this._name = name;
        }

        // Gets participant name

        public string Name
        {
            get { return _name; }
        }

        // Gets chatroom

        public MediatorChat Chatroom
        {
            set { _chatroom = value; }
            get { return _chatroom; }
        }

        // Sends message to given participant

        public void Send(string to, string message)
        {
            _chatroom.Send(_name, to, message);
        }


        // Receives message from given participant

        public virtual void Receive(
            string from, string message)
        {
            Debug.WriteLine("{0} to {1}: '{2}'",
                from, Name, message);
        }
    }
}