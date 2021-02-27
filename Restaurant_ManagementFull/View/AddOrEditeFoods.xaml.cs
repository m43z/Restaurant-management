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
  /// Interaction logic for AddOrEditeFoods.xaml
  /// </summary>
  public partial class AddOrEditeFoods : Window
  {
    private Context _context = new Context();
    //private Food _selectFood;
    private Food _selectFood { get; set; }
    public AddOrEditeFoods()
    {
      InitializeComponent();
    }

    private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
      DragMove();
    }


    private void BtnAddCategoryFood(object sender, RoutedEventArgs e)
    {

    }

    private void BtnAddFood(object sender, RoutedEventArgs e)
    {
      if (_selectFood != null)
      {
        _selectFood.Title = TxtTitleFood.Text;
        _selectFood.Price = Convert.ToDecimal(TxtPriceFood.Text);
        _selectFood.Decreption = TxtTitleFood.Text;
        _selectFood.TypeFoodId = (int)CmbFoodType.SelectedValue;
        _context.Entry(_selectFood).State = EntityState.Modified;

      }
      else
      {
        _selectFood = new Food
        {
          TypeFoodId = (int)CmbFoodType.SelectedValue,
          Title = TxtTitleFood.Text,
          Price = Convert.ToDecimal(TxtPriceFood.Text),
          Decreption = TxtDecreptionFood.Text,

        };
        _context.FoodTbl.Add(_selectFood);
      }
      _context.SaveChanges();
      RefreshCmbFood();
      ClearFoodWnd();
      //DvgFoods.ItemsSource = _context.FoodTbl.ToList();
    }

    public void ClearFoodWnd()
    {
      TxtTitleFood.Clear();
      TxtPriceFood.Clear();
      TxtDecreptionFood.Clear();
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
      RefreshCmbFood();
      CmbFoodType.ItemsSource = _context.LookupTbl.Where(l => l.GourpId == 20).ToList();
    }

    private void BtnCLoseFoodWnd(object sender, RoutedEventArgs e)
    {
      DialogResult = true;
    }

    private void CmbFoodType_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      RefreshCmbFood();
    }

    private void RefreshCmbFood()
    {
      var Id = CmbFoodType.SelectedValue;
      switch (Id)
      {
        case 201:
          DvgFoods.ItemsSource = _context.FoodTbl.Where(f => f.TypeFoodId == 201).ToList();
          break;
        case 202:
          DvgFoods.ItemsSource = _context.FoodTbl.Where(f => f.TypeFoodId == 202).ToList();
          break;
        case 203:
          DvgFoods.ItemsSource = _context.FoodTbl.Where(f => f.TypeFoodId == 203).ToList();
          break;
        case 204:
          DvgFoods.ItemsSource = _context.FoodTbl.Where(f => f.TypeFoodId == 204).ToList();
          break;
        case 205:
          DvgFoods.ItemsSource = _context.FoodTbl.Where(f => f.TypeFoodId == 205).ToList();
          break;
        case 206:
          DvgFoods.ItemsSource = _context.FoodTbl.Where(f => f.TypeFoodId == 206).ToList();
          break;
      }
    }

    private void DvgFoods_MouseDoubleClick(object sender, MouseButtonEventArgs e)
    {
      _selectFood = DvgFoods.SelectedItem as Food;
      TxtTitleFood.Text = _selectFood.Title;
      TxtPriceFood.Text = _selectFood.Price.ToString();
      TxtDecreptionFood.Text = _selectFood.Decreption;
      CmbFoodType.SelectedValue = _selectFood.TypeFoodId;
    }

    private void BtnRemoveFood(object sender, RoutedEventArgs e)
    {
      if (_selectFood != null)
      {
        if (MessageBox.Show("آیا از حذف کردن این مورد مطمیئن هستید؟ ", "سوال", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
        {
          _context.FoodTbl.Remove(_selectFood);
          _context.SaveChanges();
          RefreshCmbFood();
        }
      }
    }

    private void DvgFoods_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
    {
      _selectFood = DvgFoods.SelectedItem as Food;
    }
  }
}
