/* Author: Luke Hetrick
 * Class name: ThalmorTripleCustom.xaml.cs
 * Purpose: Class used to customize the Thalmor Triple Burger order
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
    /// Interaction logic for ThalmorTripleCustom.xaml
    /// </summary>
    public partial class ThalmorTripleCustom : UserControl
    {
        ThalmoreTriple burger = new ThalmoreTriple();
        OrderComponent order;
        public ThalmorTripleCustom(OrderComponent o)
        {
            InitializeComponent();
            order = o;
            this.DataContext = burger;
            bunCheck.DataContext = burger.Bun;
            mustardCheck.DataContext = burger.Mustard;
            pickleCheck.DataContext = burger.Pickle;
            cheeseCheck.DataContext = burger.Cheese;
            ketchupCheck.DataContext = burger.Ketchup;
            mayoCheck.DataContext = burger.Mayo;
            tomatoCheck.DataContext = burger.Tomato;
            lettuceCheck.DataContext = burger.Lettuce;
            eggCheck.DataContext = burger.Egg;
            baconCheck.DataContext = burger.Bacon;
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
