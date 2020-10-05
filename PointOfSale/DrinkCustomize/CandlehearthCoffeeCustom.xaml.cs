/* Author: Luke Hetrick
 * Class name: CandlehearthCoffee.xaml.cs
 * Purpose: Class used to customize the CandlehearthCoffee order
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BleakwindBuffet.Data.Drinks;
namespace PointOfSale.DrinkCustomize
{
    /// <summary>
    /// Interaction logic for CandelhearthCoffeeCustom.xaml
    /// </summary>
    public partial class CandlehearthCoffeeCustom : UserControl
    {
        CandlehearthCoffee coffee = new CandlehearthCoffee();
        OrderComponent order;
        public CandlehearthCoffeeCustom(OrderComponent o)
        {
            InitializeComponent();
            order = o;
            this.DataContext = coffee;
            decafCheck.DataContext = coffee.Decaf;
            iceCheck.DataContext = coffee.Decaf;
            creamCheck.DataContext = coffee.Decaf;
            sizeButtons.DataContext = coffee.Size;
        }

        /// <summary>
        /// button handeler for adding entree to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addToOrder(object sender, RoutedEventArgs e)
        {
            order.menuSelectionBorder.Child = new MenuSelection(order);
        }

    }
}
