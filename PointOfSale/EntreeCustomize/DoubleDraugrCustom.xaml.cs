/* Author: Luke Hetrick
 * Class name: DoubleDraugrCustom.xaml.cs
 * Purpose: Class used to customize the Double Draugr order
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
using BleakwindBuffet.Data.Entrees;
namespace PointOfSale.EntreeCustomize
{
    /// <summary>
    /// Interaction logic for DoubleDraugrCustom.xaml
    /// </summary>
    public partial class DoubleDraugrCustom : UserControl
    {
        OrderComponent order;
        DoubleDraugr burger = new DoubleDraugr();
        public DoubleDraugrCustom(OrderComponent o)
        {
            InitializeComponent();
            order = o;
            bunCheck.DataContext = burger.Bun;
            mustardCheck.DataContext = burger.Mustard;
            pickleCheck.DataContext = burger.Pickle;
            cheeseCheck.DataContext = burger.Cheese;
            ketchupCheck.DataContext = burger.Ketchup;
            mayoCheck.DataContext = burger.Mayo;
            tomatoCheck.DataContext = burger.Tomato;
            lettuceCheck.DataContext = burger.Lettuce;
            this.DataContext = burger;
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
