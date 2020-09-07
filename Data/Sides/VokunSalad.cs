/* Author: Luke Hetrick
 * Class name: VokunSalad.cs
 * Purpose: Class used to represent Vokun Salad on the menu
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// class to defne the Vokun Salad
    /// </summary>
    public class VokunSalad
    {

        /// <value>
        /// gets and sets the size of the salad. default Small
        /// </value>
        private Size size = Size.Small;
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }

        /// <value>
        /// the get for the price of the salad
        /// depends on the size
        /// </value>
        public double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 0.93;
                    case Size.Medium: return 1.28;
                    case Size.Large: return 1.82;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }            
        }

        /// <value>
        /// provides the get and set values for the calories of the salad.
        /// depends on the size
        /// </value>
        public uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 41;
                    case Size.Medium: return 52;
                    case Size.Large: return 73;
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
        /// sends the description of the salad based on size
        /// </summary>
        /// <returns>name and size of the salad</returns>
        public override string ToString()
        {
            return size.ToString() + " Vokun Salad";
        }


    }
}
