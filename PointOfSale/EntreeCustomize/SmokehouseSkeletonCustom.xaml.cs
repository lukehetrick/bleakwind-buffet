/* Author: Luke Hetrick
 * Class name: SmokehouseSkeletonCustom.xaml.cs
 * Purpose: Class used to customize the Smokehouse Skeleton order
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
    /// Interaction logic for SmokehouseSkeletonCustom.xaml
    /// </summary>
    public partial class SmokehouseSkeletonCustom : UserControl
    {
        OrderComponent order;
        SmokehouseSkeleton skeleton = new SmokehouseSkeleton();
        public SmokehouseSkeletonCustom(OrderComponent o)
        {
            InitializeComponent();
            order = o;
            pancakeCheck.DataContext = skeleton.Pancake;
            HashbrownCheck.DataContext = skeleton.HashBrowns;
            EggCheck.DataContext = skeleton.Egg;
            sasaugeLinkCheck.DataContext = skeleton.SausageLink;
            this.DataContext = skeleton;

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
