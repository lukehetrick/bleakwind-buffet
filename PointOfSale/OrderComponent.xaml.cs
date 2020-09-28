/* Author: Luke Hetrick
 * Class name: OrderComponent.xaml.cs
 * Purpose: Class used to contain the list of items ordered and to create screen space for the menu options
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderComponent.xaml
    /// </summary>
    public partial class OrderComponent : UserControl
    {
        public OrderComponent()
        {
            InitializeComponent();
            //allows the children to reference this component
            var childScreen = new MenuSelection(this);
            menuSelectionBorder.Child = childScreen;
        }

        
        
    }
}
