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
    /// Class to contain Candle hearth coffee
    /// </summary>
    public class CandlehearthCoffee
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
        private double price;
        public double Price
        {
            get => price;
            set
            {
                switch (size)
                {
                    case Size.Small:
                        price = 0.75;
                        break;
                    case Size.Medium:
                        price = 1.25;
                        break;
                    case Size.Large:
                        price = 1.75;
                        break;
                }
            }
        }

        /// <value>
        /// provides the get and set values for the calories of the drink.
        /// depends on size of drink
        /// </value>
        private uint calories;
        public uint Calories
        {
            get => calories;
            set
            {
                switch (size)
                {
                    case Size.Small:
                        calories = 7;
                        break;
                    case Size.Medium:
                        calories = 10;
                        break;
                    case Size.Large:
                        calories = 20;
                        break;
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
        public List<string> SpecialInstructions
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
                return size.ToString() + " Decaf Candlehearth Coffee";
            }
            else
            {
                return size.ToString() + " Candlehearth Coffee";
            }
            
        }

    }
}
