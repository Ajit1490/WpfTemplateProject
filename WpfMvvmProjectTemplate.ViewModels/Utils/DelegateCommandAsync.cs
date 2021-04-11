using System;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfMvvmProjectTemplate.Utils
{
    public sealed class DelegateCommandAsync : ICommand
    {
        readonly Func<object, Task> _execute;
        readonly Func<bool> _canExecute;

        public DelegateCommandAsync(Func<object, Task> execute)
            : this(execute, null)
        { }

        public DelegateCommandAsync(Func<object, Task> execute, Func<bool> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute.Invoke();
        }

        public async void Execute(object parameter)
        {
            await _execute?.Invoke(parameter);
        }

        public void OnCanExecuteChanged()
        {
            CommandManager.InvalidateRequerySuggested();
        }
    }
}
