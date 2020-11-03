/* Author: Luke Hetrick
 * Class name: VokunSalad.cs
 * Purpose: Class used to represent Vokun Salad on the menu
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// class to defne the Vokun Salad. Inherits from the Side class
    /// </summary>
    public class VokunSalad : Side, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Property getter for the private name variable
        /// </summary>
        public override string Name
        {
            get => "Vokun Salad";
        }

        /// <value>
        /// the get for the price of the salad
        /// depends on the size
        /// </value>
        public override double Price
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
        public override uint Calories
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
        public override List<string> SpecialInstructions
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
            return Size.ToString() + " Vokun Salad";
        }


    }
}
