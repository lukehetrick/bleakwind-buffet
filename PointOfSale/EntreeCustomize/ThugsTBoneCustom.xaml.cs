/* Author: Luke Hetrick
 * Class name: ThugsTBoneCustom.xaml.cs
 * Purpose: Class used to customize the Thugs T-bone order
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
    /// Interaction logic for ThugsTBoneCustom.xaml
    /// </summary>
    public partial class ThugsTBoneCustom : UserControl
    {
        ThugsTBone tbone = new ThugsTBone();
        OrderComponent order;

        public ThugsTBoneCustom(OrderComponent o)
        {
            InitializeComponent();
            order = o;
            this.DataContext = tbone;
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
