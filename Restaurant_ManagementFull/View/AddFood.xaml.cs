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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Restaurant_ManagementFull.Models;
using System.Data.Entity;

namespace Restaurant_ManagementFull
{
  /// <summary>
  /// Interaction logic for CodingWnd.xaml
  /// </summary>
  public partial class AddFood : Window
  {
    private Context _context = new Context();
    private Lookup _selectedLookup;
    private Lookup _selectRoot;
    public AddFood()
    {
      InitializeComponent();
    }

    private void BtnAddCoding(object sender, RoutedEventArgs e)
    {
      GrdAddCoding.Visibility = Visibility.Visible;
      GrdBtn.Visibility = Visibility.Collapsed;
    }

    private void BtnEditeCoding(object sender, RoutedEventArgs e)
    {
      GrdAddCoding.Visibility = Visibility.Visible;
      GrdBtn.Visibility = Visibility.Collapsed;

    }

    private void BtnCancelAdd(object sender, RoutedEventArgs e)
    {
      GrdAddCoding.Visibility = Visibility.Collapsed;
      GrdBtn.Visibility = Visibility.Visible;
    }

    private void CloseCodingPage(object sender, RoutedEventArgs e)
    {
      Close();
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
      RefreshList();
    }

    private void RefreshList()
    {
      var root = _context.LookupTbl.Where(l => l.GourpId == 0).ToList();
      DvgRoot.ItemsSource = root;
      //if (_selectRoot == null)
      //{
      //  _selectRoot = root.FirstOrDefault();
      //}
      //DvgRoot.SelectedItem = _selectRoot;
      if (DvgRoot.SelectedItem != null)
      {
        DvgChild.ItemsSource = _context.LookupTbl.Where(l => l.GourpId == _selectRoot.Id).ToList();
      }
    }

    private void BtnAddOrEditeSave(object sender, RoutedEventArgs e)
    {
      _selectedLookup.Title = TxtTitleCoding.Text;
      _context.Entry(_selectedLookup).State = EntityState.Modified;
      _context.SaveChanges();
      RefreshList();
      //var SelectedRoot = (Lookup)DvgRoot.SelectedItem;


      //if (SelectedRoot.GourpId == 0)
      //{
      //  SelectedRoot.Title = TxtTitleCoding.Text;

      //}

      //if (SelectedRoot.GourpId != 0)
      //{
      //  SelectedRoot.Title = TxtTitleCoding.Text;
      //}

    }

    private void DvgRoot_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      _selectRoot = DvgRoot.SelectedItem as Lookup;
      DvgChild.ItemsSource = _context.LookupTbl?.Where(l => l.GourpId == _selectRoot.Id).ToList();
      _selectedLookup = _selectRoot;
      TxtTitleCoding.Text = _selectedLookup?.Title;
    }

    private void DvgChild_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      _selectedLookup = DvgChild.SelectedItem as Lookup;
      TxtTitleCoding.Text = _selectedLookup?.Title;
      /*if (DvgChild.SelectedItem != null)
      {
        var RowId = (int)DvgChild.SelectedValue;
        var FindRow = _context.LookupTbl.Find(RowId);
        TxtTitleCoding.Text = FindRow.Title;
      }*/
    }
  }
}
