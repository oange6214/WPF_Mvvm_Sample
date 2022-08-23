using System;
using System.Windows.Input;

namespace MvvmDemo.Command
{
    public class RelayCommand : ICommand
    {
        Action<object> _execute;
        Func<object, bool> _canExecute;
        bool _canExecuteCache;

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute, bool canExecuteCache)
        {
            _execute = execute;
            _canExecute = canExecute;
            _canExecuteCache = canExecuteCache;
        }

        public bool CanExecute(object? parameter)
        {
            if (_canExecute == null)
            {
                return true;
            }
            else
            {
                return _canExecute(parameter);
            }
        }

        public void Execute(object? parameter)
        {
            _execute(parameter);
        }

        public event EventHandler? CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }
    }
}
