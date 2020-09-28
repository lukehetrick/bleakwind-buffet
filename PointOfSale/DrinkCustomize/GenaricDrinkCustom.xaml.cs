/* Author: Luke Hetrick
 * Class name: GenaricDrinkCustom.xaml.cs
 * Purpose: Class used to customize a basic drink
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

namespace PointOfSale.DrinkCustomize
{
    /// <summary>
    /// Interaction logic for GenaricDrink.xaml
    /// </summary>
    public partial class GenaricDrinkCustom : UserControl
    {
        OrderComponent order;
        public GenaricDrinkCustom(OrderComponent o)
        {
            InitializeComponent();
            order = o;
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
