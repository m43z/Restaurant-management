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
using Restaurant_ManagementFull.DataBase;
using System.Data.Entity;
using Restaurant_ManagementFull.Models;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Prism.Services.Dialogs;

namespace Restaurant_ManagementFull
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    private Context _context = new Context();
    private Customer _selectedCustomer;
    private Food _food;
    private List<Invoice> _invoices;
    private List<InvoiceDetails> _invoiceDetails;
    private InvoiceDetails _invoiceDetailses;
    public Invoice _invoice { get; set; }

    public DateTime Time { get; set; } = DateTime.Now;

    public MainWindow()
    {
      InitializeComponent();
      TxbTime.Text = DateTime.Now.ToString("t");
      
    }

    private void BtnCloseApp_Click(object sender, RoutedEventArgs e)
    {
      Application.Current.Shutdown();
    }

    private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
      DragMove();
    }

    private void BtnAddCustomer(object sender, RoutedEventArgs e)
    {

      AddCustomerWnd CostomerWnd = new AddCustomerWnd();

      if (CostomerWnd.ShowDialog().Value)
      {
        ItcCustomer.ItemsSource = _context.CustomerTbl.ToList();
      }
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
      _invoiceDetails = new List<InvoiceDetails>();
      DataGridInviceDetails.ItemsSource = _invoiceDetails;
      var Dvglist = _invoiceDetails;

      Refresh();
      RefreshCmbFood();
      ItcCustomer.ItemsSource = _context.CustomerTbl.ToList();
      ItcFood.ItemsSource = _context.FoodTbl.ToList();
      DataGridInviceload.ItemsSource = _context.InvoiceTbl.Where(i=>i.Date.Day==Time.Date.Day).ToList();
    }

    public void Refresh()
    {
      CmbFoodType.ItemsSource = _context.LookupTbl.Where(l => l.GourpId == 20).ToList();
      ItcCustomer.ItemsSource = _context.CustomerTbl.ToList();
    }

    private void BtnEditeCustomer(object sender, RoutedEventArgs e)
    {
      if (_selectedCustomer != null)
      {
        AddCustomerWnd CustomerWnd = new AddCustomerWnd();
        CustomerWnd.Customer = _selectedCustomer;
        if (CustomerWnd.ShowDialog().Value)
        {
          ItcCustomer.ItemsSource = _context.CustomerTbl.ToList();
        }
      }
    }

    private void BtnRemove(object sender, RoutedEventArgs e)
    {
      if (_selectedCustomer != null)
      {
        if (MessageBox.Show($" آیا از حذف {_selectedCustomer.FullName} مطمئن هستید؟", "هشدار", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
        {
          _context.CustomerTbl.Remove(_selectedCustomer);
          _context.SaveChanges();
          ItcCustomer.ItemsSource = _context.CustomerTbl.ToList();
        }
      }
    }

    private void BtnSubmit(object sender, RoutedEventArgs e)
    {
      var newInvoice = new Invoice
      {
        Date = DateTime.Now,
        CustomerId = _selectedCustomer.Id,
        InvoiceDetailses = _invoiceDetails
      };
      _context.InvoiceTbl.Add(newInvoice);
      if (_context.SaveChanges() > 0)
      {
        _selectedCustomer = null;
        TxtNumberFood.Text = "1";
        CmbFoodType.SelectedIndex = 0;
        CmbFood.SelectedIndex = 0;
        _invoiceDetails.Clear();
        DataGridInviceDetails.Items.Refresh();
      }
      DataGridInviceDetails.Visibility = Visibility.Collapsed;
      DataGridInviceload.Visibility = Visibility.Visible;
      DataGridInviceload.ItemsSource = _context.InvoiceTbl.Where(i => i.Date.Day == Time.Date.Day).ToList();
      TxbAmount.FontSize = 16;
      TxbAmount.Text = "سفارش شما با موفقیت ثبت شد.";


    }

    private void DvgCustomer_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      _selectedCustomer = ItcCustomer.SelectedItem as Customer;
      if (_selectedCustomer != null)
      {
        TxbCustomerName.Text = _selectedCustomer.FullName;
      }
    }

    private void BtnFoodCatogory(object sender, RoutedEventArgs e)
    {
      AddOrEditeFoods FoodWnd = new AddOrEditeFoods();
      if (FoodWnd.ShowDialog().Value)
      {
        CmbFoodType.ItemsSource = _context.LookupTbl.Where(l => l.GourpId == 20).ToList();
      }
    }

    public void RefreshCmbFood()
    {


    }

    private void CmbFood_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      CmbFood.ItemsSource = _context.FoodTbl.Where(f => f.TypeFoodId == (int)CmbFoodType.SelectedValue).ToList();
      CmbFood.SelectedIndex = 0;
    }

    private void CmbFood_Selected(object sender, RoutedEventArgs e)
    {

    }

    private void BtnInvoiceCustomer(object sender, RoutedEventArgs e)
    {
      DataGridInviceDetails.Visibility = Visibility.Collapsed;
      DataGridInvice.Visibility = Visibility.Visible;
      var a = (Customer)((Button)sender).DataContext;
      DataGridInvice.ItemsSource = _context.InvoiceTbl.Where(i => i.CustomerId == a.Id).Include("InvoiceDetailses").ToList();
    }

    private void BtnAddFood_Click(object sender, RoutedEventArgs e)
    {
      var food = CmbFood.SelectedItem as Food;
      var newDetails = new InvoiceDetails
      {
        Count = Convert.ToInt32(TxbCount.Text),
        Food = food,
        FoodsId = food.Id,
        Price = food.Price
      };

      _invoiceDetails.Add(newDetails);
      DataGridInviceDetails.Visibility = Visibility.Visible;
      DataGridInvice.Visibility = Visibility.Collapsed;
      DataGridInviceload.Visibility = Visibility.Collapsed;
      DataGridInviceDetails.Items.Refresh();
      TxbAmount.FontSize = 22;
      TxbAmount.Text = $"مبلغ کل : {_invoiceDetails.Sum(d => d.TotalPrice).ToString("N0")}";

    }

    private void BtnPlus_Click(object sender, RoutedEventArgs e)
    {
      string value = TxbCount.Text;
      int number = (int.Parse(value)) + 1;
      TxbCount.Text = number.ToString();
    }

    private void BtnMinez_Click(object sender, RoutedEventArgs e)
    {
      if (TxbCount.Text != "1")
      {
        string value = TxbCount.Text;
        int number = (int.Parse(value)) - 1;
        TxbCount.Text = number.ToString();
      }
    }

    private void ItcCustomer_MouseDoubleClick(object sender, MouseButtonEventArgs e)
    {

      DataGridInviceDetails.Visibility = Visibility.Collapsed;
      DataGridInvice.Visibility = Visibility.Visible;
      _selectedCustomer = ItcCustomer.SelectedItem as Customer;
      DataGridInvice.ItemsSource = _context.InvoiceTbl.Where(i => i.CustomerId == _selectedCustomer.Id).Include("Customer").ToList();

    }

    private void DataGridInvice_MouseDoubleClick(object sender, MouseButtonEventArgs e)
    {
      //_invoiceDetails = DataGridInviceDetails.ItemsSource as _invoiceDetailses;
      //DataGridInviceDetails1.Visibility = Visibility.Visible;
      
      //DataGridInviceDetails1.ItemsSource = _context.FoodTbl.Where(f=>f.Id==).ToList();

    }

    private void BtnInvoiceDeatils_Click(object sender, RoutedEventArgs e)
    {
      var a = _invoice.Id;

      DataGridInviceload.Visibility = Visibility.Collapsed;
      DataGridInviceDetails.Visibility = Visibility.Collapsed;
      DataGridInvice.Visibility = Visibility.Collapsed;
      DataGridInviceDetails1.Visibility = Visibility.Visible;
      var Dvglist = _context.InvoiceDetailsTbl.Where(i => i.InvoiceId == a).Include("Food").ToList();

    }

    private void DataGridInviceload_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      _invoice = DataGridInviceload.SelectedItem as Invoice;
    }
  }
}
