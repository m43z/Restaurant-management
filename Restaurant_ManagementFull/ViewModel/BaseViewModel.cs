using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace Restaurant_ManagementFull.ViewModel
{
  public class BaseViewModel : INotifyPropertyChanged
  {
    public event PropertyChangedEventHandler PropertyChanged;
    public void OnPropertyChenged<T>(ref T fild, T value, [CallerMemberName] string PropertyName = null)
    {
      fild = value;
      if (!EqualityComparer<T>.Default.Equals(fild, value))
      {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
      }
    }
  }
}
