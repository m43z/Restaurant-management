using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Restaurant_ManagementFull.ViewModel
{
  public class RellayCommand : ICommand
  {
    public event EventHandler CanExecuteChanged;
    private readonly Action<object> _execute;
    private readonly Predicate<object> _canExecute;

    public void RiseCanExecute()
    {
      CanExecuteChanged?.Invoke(this, new EventArgs());
    }

    public RellayCommand(Action<object> execute, Predicate<object> canExecute)
    {
      _execute = execute;
      _canExecute = canExecute;
    }

    public RellayCommand(Action<object> execute)
    {
      _execute = execute;
    }

    public bool CanExecute(object parameter)
    {
      return _canExecute == null ? true : _canExecute(parameter);
    }

    public void Execute(object parameter)
    {
      _execute(parameter);
    }
  }
}
