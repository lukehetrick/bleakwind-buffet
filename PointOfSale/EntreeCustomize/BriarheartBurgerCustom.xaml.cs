/* Author: Luke Hetrick
 * Class name: BriarheartBurgerCustom.xaml.cs
 * Purpose: Class used to customize the Briarheart Burger order
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
    /// Interaction logic for BriarheartBurgerCustom.xaml
    /// </summary>
    public partial class BriarheartBurgerCustom : UserControl
    {
        OrderComponent order;
        
        public BriarheartBurgerCustom(OrderComponent o)
        {
            InitializeComponent();
            BriarheartBurger burger = new BriarheartBurger();
            bunCheck.DataContext = burger.Bun;
            mustardCheck.DataContext = burger.Mustard;
            pickleCheck.DataContext = burger.Pickle;
            cheeseCheck.DataContext = burger.Cheese;
            ketchupCheck.DataContext = burger.Ketchup;
            this.DataContext = burger;
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
