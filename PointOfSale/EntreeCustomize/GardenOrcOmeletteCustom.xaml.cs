/* Author: Luke Hetrick
 * Class name: GardenOrcOmelette.xaml.cs
 * Purpose: Class used to customize the Garden Orc Omelette order
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
    /// Interaction logic for GardenOrcOmeletteCustom.xaml
    /// </summary>
    public partial class GardenOrcOmeletteCustom : UserControl
    {
        OrderComponent order;
        
        public GardenOrcOmeletteCustom(OrderComponent o)
        {
            InitializeComponent();
            order = o;
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            this.DataContext = omelette;
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
