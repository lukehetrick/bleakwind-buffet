/* Author: Luke Hetrick
 * Class name: Entree.cs
 * Purpose: Entree base class for entree classes to inherit properties of
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public abstract class Entree : IOrderItem
    {
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
        /// special instructions to prepare the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
