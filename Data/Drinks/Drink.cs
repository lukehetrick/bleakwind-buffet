/* Author: Luke Hetrick
 * Class name: Drink.cs
 * Purpose: Drink base class for Drink classes to inherit properties of
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// generic base class for properties of all drinks
    /// </summary>
    public abstract class Drink : IOrderItem
    {
        /// <summary>
        /// virtual size of drink because all sizes are the same types and likely won't need to be overridden
        /// </summary>
        public virtual Size Size { get; set; }

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

        
    }
}
