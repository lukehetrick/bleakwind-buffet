/* Author: Luke Hetrick
 * Class name: MadOtarGrits.cs
 * Purpose: Class used to represent Mad Otar Grits on the menu
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// class to define the Mad Otar Grits. Inherits from the Side class
    /// </summary>
    public class MadOtarGrits : Side, IOrderItem
    {
        /// <value>
        /// the get for the price of the grits
        /// depends on the size
        /// </value>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 1.22;
                    case Size.Medium: return 1.58;
                    case Size.Large: return 1.93;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }            
        }

        /// <value>
        /// provides the get and set values for the calories of the grits.
        /// depends on the size
        /// </value>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 105;
                    case Size.Medium: return 142;
                    case Size.Large: return 179;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }            
        }

        /// <value>
        /// no properties so always returns empty list
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }


        /// <summary>
        /// sends the description of the grits based on size
        /// </summary>
        /// <returns>name and size of the grits</returns>
        public override string ToString()
        {
            return Size.ToString() + " Mad Otar Grits";
        }


    }
}
