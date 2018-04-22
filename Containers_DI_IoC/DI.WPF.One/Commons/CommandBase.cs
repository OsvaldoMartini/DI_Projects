using System;
using System.Diagnostics;
using System.Windows.Input;

namespace DI.WPF.One.Commons
{
    public class CommandBase : ICommand
    {
        private readonly Action<object> execute;
        private readonly Predicate<object> canExecute;

        public CommandBase(Action<object> execute)
            : this(execute, null)
        {
        }

        public CommandBase(Action<object> execute, Predicate<object> canExecute)
        {
            if (execute == null)
            {
                throw new ArgumentNullException("execute");
            }

            this.execute = execute;
            this.canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        [DebuggerStepThrough]
        public bool CanExecute(object parameter)
        {
            return canExecute == null ? true : canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            execute(parameter);
        }
    }
}