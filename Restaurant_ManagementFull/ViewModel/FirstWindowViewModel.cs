using System;
using System.Collections.Generic;
using System.Linq;
using Restaurant_ManagementFull.Models;
using Restaurant_ManagementFull.DataBase;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Restaurant_ManagementFull.ViewModel
{
  public class FirstWindowViewModel : BaseViewModel
  {
    private readonly Context _context;
    public ObservableCollection<Customer> CustomerList { set; get; }
    public Customer SelectCustomer { get; set; }

    public FirstWindowViewModel()
    {
      _context = new Context();
      CustomerList = new ObservableCollection<Customer>();
      foreach (var customer in _context.CustomerTbl)
        CustomerList.Add(customer);
    }

    public RellayCommand SaveCostomerCommand { get => new RellayCommand(p => onSave(p));}
    private void onSave(object p)
    {
      var newCustomer = new Customer();
      var CustomerWnd = new AddCustomerWnd();
      CustomerWnd.DataContext = newCustomer;
      if (CustomerWnd.ShowDialog().Value)
        _context.CustomerTbl.Add(newCustomer);
      _context.SaveChanges();
      CustomerList.Add(newCustomer);
    }

    public RellayCommand EditeCustomerCommand { get => new RellayCommand(p => onEdite(p) /*, p => SelectCustomer != null*/); }
    private void onEdite(object p)
    {
      var CustomerWnd = new AddCustomerWnd();
      CustomerWnd.DataContext = SelectCustomer;
      if (CustomerWnd.ShowDialog().Value)
        _context.Entry(SelectCustomer).State = EntityState.Modified;
      _context.SaveChanges();
      CustomerList.Add(SelectCustomer);
      CustomerList.Remove(SelectCustomer);
    }

    public RellayCommand RemovceCustomerCommand { get => new RellayCommand(p => onDelete(p)/*, p => SelectCustomer != null*/); }
    private void onDelete(object p)
    {
      _context.CustomerTbl.Remove(SelectCustomer);
      _context.SaveChanges();
      CustomerList.Remove(SelectCustomer);
    }
  }
}
