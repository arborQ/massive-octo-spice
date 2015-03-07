using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace MassiveOctoSpice.Common
{
    public class Command : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private Action<object> ActionCommand;
        private Func<object, bool> CanExecuteAction;
        public Command(Action<object> command, Func<object, bool> canExecute = null)
        {
            ActionCommand = command ?? (a => { });
            CanExecuteAction = canExecute ?? ( a => true);
        }       

        public bool CanExecute(object parameter)
        {
            return CanExecuteAction(parameter);
        }

        public void Execute(object parameter)
        {
            if (CanExecute(parameter))
                ActionCommand(parameter);
        }
    }
}
