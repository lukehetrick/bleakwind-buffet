/* Author: Luke Hetrick
 * Class name: Side.cs
 * Purpose: Side base class for side classes to inherit properties of
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// generic class for all sides to inherit the properties of
    /// </summary>
    public abstract class Side : IOrderItem
    {
        /// <summary>
        /// size of side
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
        /// special instructions to prepare the side
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }


    }
}
