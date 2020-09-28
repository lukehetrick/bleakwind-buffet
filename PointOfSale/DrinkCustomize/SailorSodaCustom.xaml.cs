/* Author: Luke Hetrick
 * Class name: SailorSodaCustom.xaml.cs
 * Purpose: Class used to customize the Sailor Soda order
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
    /// Interaction logic for SailorSodaCustom.xaml
    /// </summary>
    public partial class SailorSodaCustom : UserControl
    {
        OrderComponent order;
        public SailorSodaCustom(OrderComponent o)
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
