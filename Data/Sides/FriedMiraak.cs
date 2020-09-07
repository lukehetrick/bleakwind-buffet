/* Author: Luke Hetrick
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent Fried Miraak hashbrown pancakes on the menu
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// class to define the Fired Miraak
    /// </summary>
    public class FriedMiraak
    {

        /// <value>
        /// gets and sets the size of the pancakes. default Small
        /// </value>
        private Size size = Size.Small;
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }

        /// <value>
        /// the get for the price of the pancakes
        /// depends on the size
        /// </value>
        public double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 1.78;
                    case Size.Medium: return 2.01;
                    case Size.Large: return 2.88;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }           
        }

        /// <value>
        /// provides the get and set values for the calories of the pancakes.
        /// depends on the size
        /// </value>
        public uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 151;
                    case Size.Medium: return 236;
                    case Size.Large: return 306;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }            
        }

        /// <value>
        /// no properties so always returns empty list
        /// </value>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }


        /// <summary>
        /// sends the description of the pancakes based on size
        /// </summary>
        /// <returns>name of side and size</returns>
        public override string ToString()
        {
            return size.ToString() + " Fried Miraak";
        }


    }
}
