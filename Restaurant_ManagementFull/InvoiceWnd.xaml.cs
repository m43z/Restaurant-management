using Restaurant_ManagementFull.DataBase;
using Restaurant_ManagementFull.Models;
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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Restaurant_ManagementFull
{
  /// <summary>
  /// Interaction logic for InvoiceWnd.xaml
  /// </summary>
  public partial class InvoiceWnd : Window
  {
    private Context _context = new Context();
    public Customer _selectCustomer { get; set; }

    public InvoiceWnd()
    {
      InitializeComponent();
      //_customer = new Customer();
      //_invoice = new Invoice();
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
     
      //DvgInvoice.ItemsSource = _context.InvoiceTbl.Include("Customer").Include("InvoiceDetailses").ToList();
     // DvgInvoice.ItemsSource = _context.InvoiceTbl.Where(i => i.CustomerId == _selectCustomer.Id).ToList();
    }
  }
}
