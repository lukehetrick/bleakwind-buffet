/* Author: Luke Hetrick
 * Class name: MenuSelection.xaml.cs
 * Purpose: Class used dispay the menu and handle button controls of the menu
 */
using BleakwindBuffet.Data.Entrees;
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
using PointOfSale.EntreeCustomize;
using PointOfSale.DrinkCustomize;
using PointOfSale.SideCustomize;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuSelection.xaml
    /// </summary>
    public partial class MenuSelection : UserControl
    {
        public OrderComponent order;
        public MenuSelection(OrderComponent parent)
        {
            InitializeComponent();
            order = parent;
        }

        
        //ENTREES

        /// <summary>
        /// Button handeler opens the customize menu for item 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void BriarheartBurgerSelected(object sender, RoutedEventArgs e)
        {
            order.menuSelectionBorder.Child = new BriarheartBurgerCustom(order);            
        }


        /// <summary>
        /// Button handeler opens the customize menu for item 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DoubleDraugrSelected(object sender, RoutedEventArgs e)
        {
            order.menuSelectionBorder.Child = new DoubleDraugrCustom(order);
        }

        /// <summary>
        /// Button handeler opens the customize menu for item 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ThalmorTripleSelected(object sender, RoutedEventArgs e)
        {
            order.menuSelectionBorder.Child = new ThalmorTripleCustom(order);
        }


        /// <summary>
        /// Button handeler opens the customize menu for item 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SmokehouseSkeletonSelected(object sender, RoutedEventArgs e)
        {
            order.menuSelectionBorder.Child = new SmokehouseSkeletonCustom(order);
        }

        /// <summary>
        /// Button handeler opens the customize menu for item 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void GardenOrcOmeletteSelected(object sender, RoutedEventArgs e)
        {
            order.menuSelectionBorder.Child = new GardenOrcOmeletteCustom(order);
        }

        /// <summary>
        /// Button handeler opens the customize menu for item 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void PhillyPoacherSelected(object sender, RoutedEventArgs e)
        {
            order.menuSelectionBorder.Child = new PhillyPoacherCustom(order);
        }

        /// <summary>
        /// Button handeler opens the customize menu for item 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ThugsTBoneSelected(object sender, RoutedEventArgs e)
        {
            order.menuSelectionBorder.Child = new ThugsTBoneCustom(order);
        }


        //DRINKS

        /// <summary>
        /// Button handeler opens the customize menu for item. Used for Markarth Milk, Aretino Apple Juice, and Warrior Water
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void GenericDrinkSelected(object sender, RoutedEventArgs e)
        {
            order.menuSelectionBorder.Child = new GenaricDrinkCustom(order);
        }

        /// <summary>
        /// Button handeler opens the customize menu for item 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SailorSodaSelected(object sender, RoutedEventArgs e)
        {
            order.menuSelectionBorder.Child = new SailorSodaCustom(order);
        }

        /// <summary>
        /// Button handeler opens the customize menu for item 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CandlehearthCoffeeSelected(object sender, RoutedEventArgs e)
        {
            order.menuSelectionBorder.Child = new CandlehearthCoffeeCustom(order);
        }

        //SIDES
        /// <summary>
        /// Button handeler opens the customize menu for item, covers all sides 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SideSelected(object sender, RoutedEventArgs e)
        {
            order.menuSelectionBorder.Child = new SideCustom(order);
        }

    }
}
