using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using Restaurant_ManagementFull.DataBase;
using Restaurant_ManagementFull.Models;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.Entity;

namespace Restaurant_ManagementFull
{
  /// <summary>
  /// Interaction logic for AddCustomerWnd.xaml
  /// </summary>
  public partial class AddCustomerWnd : Window
  {
    private Context _context = new Context();
    public Customer Customer { get; set; }

    public AddCustomerWnd()
    {
      InitializeComponent();
    }

    private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
      DragMove();
    }

    private void BtnSaveCustomer(object sender, RoutedEventArgs e)
    {
      if (Customer != null)
      {
        Customer.FirstName = TxtFirstName.Text;
        Customer.LastName = TxtLastName.Text;
        Customer.GenderId = (int)CmbGender.SelectedValue;
        Customer.Mobile = TxtMobile.Text;
        Customer.Address = TxtAddress.Text;
        _context.Entry(Customer).State = EntityState.Modified;
      }
      else
      {
        Customer = new Customer
        {
          FirstName = TxtFirstName.Text,
          LastName = TxtLastName.Text,
          Mobile = TxtMobile.Text,
          Address = TxtAddress.Text,
          GenderId = (int)CmbGender.SelectedValue,
        };
        _context.CustomerTbl.Add(Customer);
      }


      if (_context.SaveChanges() > 0)
        DialogResult = true;
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
      if (Customer != null)
      {
        TxtFirstName.Text = Customer.FirstName;
        CmbGender.SelectedValue = Customer.GenderId;
        TxtLastName.Text = Customer.LastName;
        TxtMobile.Text = Customer.Mobile;
        TxtAddress.Text = Customer.Mobile;
        TxbTitleCustomer.Text = "ویرایش کردن مشتری";
      }
      CmbGender.ItemsSource = _context.LookupTbl.Where(l => l.GourpId == 10).ToList();
    }


    private void Button_Click(object sender, RoutedEventArgs e)
    {

    }

    private void CloseAddWnd(object sender, RoutedEventArgs e)
    {
      Close();
    }
  }
}
