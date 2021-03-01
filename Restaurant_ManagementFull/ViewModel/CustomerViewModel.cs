using Restaurant_ManagementFull.Models;
using Restaurant_ManagementFull.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Prism.Services.Dialogs;

namespace Restaurant_ManagementFull.ViewModel
{
  public class CustomerViewModel : BaseViewModel
  {
    private Context _context = new Context();
    public Customer Customer { get; set; }
    public CustomerViewModel()
    {

    }
    private RellayCommand _saveCommand;
    public RellayCommand SaveCommand
    {
      get
      {
        if (_saveCommand != null) return _saveCommand;
        _saveCommand = new RellayCommand(param => save(param));
        return _saveCommand;
      }
    }
    private void save(object param)
    {
      
      //if (Customer != null)
      //{
      //  Customer.FirstName = FirestName;
      //  Customer.LastName = LastName;
      //  Customer.GenderId = GenderId;
      //  Customer.Mobile = Mobile;
      //  Customer.Address = Address;
      //  _context.Entry(Customer).State = EntityState.Modified;
      //}
      //else
      //{
      //  Customer = new Customer
      //  {
      //    FirstName = FirestName,
      //    LastName = LastName,
      //    Mobile = Mobile,
      //    Address = Address,
      //    GenderId = GenderId,
      //  };
      //  _context.CustomerTbl.Add(Customer);
      //}
    }



    //private void WndLoaded()
    //{
    //  if (Customer != null)
    //  {
    //    FirestName = Customer.FirstName;
    //    GenderId = Customer.GenderId;
    //    LastName = Customer.LastName;
    //    Mobile = Customer.Mobile;
    //    Address = Customer.Address;
    //    //TxbTitleCustomer.Text = "ویرایش کردن مشتری";
    //  }
    // // GenderId.ItemsSource = _context.LookupTbl.Where(l => l.GourpId == 10).ToList();
    //}
    public List<Lookup> GenderLookup { get => _context.LookupTbl.Where(x => x.GourpId == 10).ToList(); }
  }
}
