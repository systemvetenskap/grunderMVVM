using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Yatzy.Commands
{
    public class RelayCommand : ICommand
    {
        private readonly Action<object> _executeWithParameter;
        private readonly Func<object, bool> _canExecuteWithParameter;
        private readonly Action _executeWithoutParameter;
        private readonly Func<bool> _canExecuteWithoutParameter;
        private readonly bool _useParameter;

        // Konstruktor för kommandon med parameter
        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _executeWithParameter = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecuteWithParameter = canExecute;
            _useParameter = true;
        }

        // Konstruktor för kommandon utan parameter
        public RelayCommand(Action execute, Func<bool> canExecute = null)
        {
            _executeWithoutParameter = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecuteWithoutParameter = canExecute;
            _useParameter = false;
        }

        // CanExecute-metod som hanterar både med och utan parameter
        public bool CanExecute(object parameter)
        {
            if (_useParameter)
            {
                return _canExecuteWithParameter == null || _canExecuteWithParameter(parameter);
            }
            else
            {
                return _canExecuteWithoutParameter == null || _canExecuteWithoutParameter();
            }
        }

        // Execute-metod som hanterar både med och utan parameter
        public void Execute(object parameter)
        {
            if (_useParameter)
            {
                _executeWithParameter(parameter);
            }
            else
            {
                _executeWithoutParameter();
            }
        }

        public event EventHandler CanExecuteChanged;

        public void RaiseCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }
}
