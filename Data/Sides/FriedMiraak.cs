/* Author: Luke Hetrick
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent Fried Miraak hashbrown pancakes on the menu
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// class to define the Fired Miraak. Inherits from the Side class
    /// </summary>
    public class FriedMiraak : Side, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Property getter for the private name variable
        /// </summary>
        public override string Name
        {
            get => "Fried Miraak";
        }

        /// <value>
        /// the get for the price of the pancakes
        /// depends on the size
        /// </value>
        public override double Price
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
        public override uint Calories
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
        public override List<string> SpecialInstructions
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
            return Size.ToString() + " Fried Miraak";
        }


    }
}
