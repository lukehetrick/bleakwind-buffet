/* Author: Luke Hetrick
 * Class name: Side.cs
 * Purpose: Side base class for side classes to inherit properties of
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// generic class for all sides to inherit the properties of
    /// </summary>
    public abstract class Side : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// description of the item
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// describes what category of item this is (Entree, Side or Drink)
        /// </summary>
        public string Category => "Side";

        /// <summary>
        /// the property changed event handler for all properties that are changeable
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private Size size;
        /// <summary>
        /// virtual size of side because all sizes are the same types and likely won't need to be overridden
        /// </summary>
        public virtual Size Size
        {
            get => size;
            set
            {
                if (size != value)
                {
                    size = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                }
            }
        }

        /// <summary>
        /// abstract price because it will need to be overrideen for every class
        /// only needs get.
        /// </summary>
        /// <value>
        /// in US dollars
        /// </value>
        public abstract double Price { get; }

        /// <summary>
        /// abstract calroies because it will need to be overrideen for every class
        /// only needs get
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// special instructions to prepare the side
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// Property that returns the name of the drink
        /// </summary>
        public abstract string Name { get; }
    }
}
