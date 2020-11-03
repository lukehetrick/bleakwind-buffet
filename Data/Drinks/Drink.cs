/* Author: Luke Hetrick
 * Class name: Drink.cs
 * Purpose: Drink base class for Drink classes to inherit properties of
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// generic base class for properties of all drinks
    /// </summary>
    public abstract class Drink : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// the property changed event handler for all properties that are changeable
        /// </summary>
        public virtual event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private Size size;
        /// <summary>
        /// virtual size of drink because all sizes are the same types and likely won't need to be overridden
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

        private bool ice = false;
        /// <value>
        /// ice value of the drink, default false
        /// </value>
        public virtual bool Ice
        {
            get => ice;
            set
            {
                if (value != ice)
                {
                    ice = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
        /// special instructions to prepare the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// Property that returns the name of the drink
        /// </summary>
        public abstract string Name { get; }
    }
}
