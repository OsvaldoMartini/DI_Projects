using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.WPF.One.Interfaces;
using DI.WPF.One.Model;

namespace DI.WPF.One.Mediators
{
    public abstract class ViewModelMediator
    {
        public abstract void Register(IViewModel vieModel);
        public abstract void Send(string message, Customer customer);
    }
}
