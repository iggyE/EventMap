using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EventMap.Front.Commands
{
    public class RelayCommand<T> : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private Action<T> _Execute { get; set; }
        private Predicate<T> _CanExecute { get; set; }

        public RelayCommand(Action<T> ExecuteMethod, Predicate<T> CanExecuteMethod)
        {
            _Execute = ExecuteMethod;
            _CanExecute = CanExecuteMethod;
        }

        public bool CanExecute(object parameter)
        {
            return _CanExecute((T)parameter);
        }

        public void Execute(object parameter)
        {
            _Execute((T)parameter);
        }
    }
}
