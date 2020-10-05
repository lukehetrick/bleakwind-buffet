/* Author: Luke Hetrick
 * Class name: SideCustom.xaml.cs
 * Purpose: Class used to customize a side order
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
using BleakwindBuffet.Data.Sides;
namespace PointOfSale.SideCustomize
{
    /// <summary>
    /// Interaction logic for SideCustom.xaml
    /// </summary>
    public partial class SideCustom : UserControl
    {
        Side side = new DragonbornWaffleFries();
        OrderComponent order;
        public SideCustom(OrderComponent o)
        {
            InitializeComponent();
            order = o;
            this.DataContext = side;
            sizeButtons.DataContext = side.Size;
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
