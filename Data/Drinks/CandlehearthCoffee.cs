/* Author: Luke Hetrick
 * Class name: CandlehearthCoffee.cs
 * Purpose: Class used to represent the Candlehearth Coffee on the menu
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class to contain Candle hearth coffee. Inherits from the Drink class
    /// </summary>
    public class CandlehearthCoffee : Drink, IOrderItem
    {

        /// <value>
        /// the get for the price of the drink
        /// depends on size of drink
        /// </value>        
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 0.75;
                    case Size.Medium: return 1.25;
                    case Size.Large: return 1.75;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }            
        }

        /// <value>
        /// provides the get and set values for the calories of the drink.
        /// depends on size of drink
        /// </value>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 7;
                    case Size.Medium: return 10;
                    case Size.Large: return 20;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }
        }


        /// <value>
        /// ice value of the drink, default false
        /// </value>
        public bool Ice { get; set; } = false;

        /// <value>
        /// value for room for cream in the coffee, default false
        /// </value>
        public bool RoomForCream { get; set; } = false;

        /// <value>
        /// value for decaf coffee, default false
        /// </value>
        public bool Decaf { get; set; } = false;

        /// <value>
        /// gets instruction list based on ice and cream variables
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                if (RoomForCream) instructions.Add("Add cream");                
                return instructions;
            }
        }


        /// <summary>
        /// sends the description of this drink based on size and caffine
        /// </summary>
        /// <returns>string with label for decaf and size of drink</returns>
        public override string ToString()
        {
            if(Decaf)
            {
                return Size.ToString() + " Decaf Candlehearth Coffee";
            }
            else
            {
                return Size.ToString() + " Candlehearth Coffee";
            }
            
        }

    }
}
