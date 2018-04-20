using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.WPF.One.Interfaces;
using DI.WPF.One.Model;

namespace DI.WPF.One.Mediators
{
    /// <summary>

    /// The 'Mediator' abstract class

    /// </summary>
    abstract class MediatorViewModel
    {
        //public abstract void Register(IViewModel vieModel);
        
        //public abstract void Send(string from, string to, string message);

        //Abstractions for Collegues Stories
        //Abstractions for the Participants in a Chat Room Story
        //public abstract void Register(AbstractViewModel viewModel);
        
        public abstract void Send(string message, AbstractViewModel viewModel);

        //public abstract void Send(string message, Customer viewModel);
    }
}
