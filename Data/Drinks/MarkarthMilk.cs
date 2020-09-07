/* Author: Luke Hetrick
 * Class name: MarkarthMilk.cs
 * Purpose: Class used to represent the Markarth Milk on the menu
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class for Markarth milk
    /// </summary>
    public class MarkarthMilk
    {

        /// <value>
        /// gets and sets the size of the drink. default Small
        /// </value>
        private Size size = Size.Small;
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }


        /// <value>
        /// the get for the price of the drink
        /// depends on size of drink
        /// </value>
        public double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 1.05;
                    case Size.Medium: return 1.11;
                    case Size.Large: return 1.22;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }            
        }


        /// <value>
        /// provides the get and set values for the calories of the drink.
        /// depends on size of drink
        /// </value>
        public uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 56;
                    case Size.Medium: return 72;
                    case Size.Large: return 93;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }            
        }


        /// <value>
        /// ice value of the drink, default false
        /// </value>
        public bool Ice { get; set; } = false;

        /// <value>
        /// gets instruction list based on ice request
        /// </value>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                return instructions;
            }
        }


        /// <summary>
        /// sends the description of this drink based on size and flavor
        /// </summary>
        /// <returns>label for drink based on size</returns>
        public override string ToString()
        {
            return size.ToString() + " Markarth Milk";
        }

    }
}
