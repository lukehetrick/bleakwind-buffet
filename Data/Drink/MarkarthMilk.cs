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
        private double price;
        public double Price
        {
            get => price;
            set
            {
                switch (size)
                {
                    case Size.Small:
                        price = 1.05;
                        break;
                    case Size.Medium:
                        price = 1.11;
                        break;
                    case Size.Large:
                        price = 1.22;
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
                        calories = 56;
                        break;
                    case Size.Medium:
                        calories = 72;
                        break;
                    case Size.Large:
                        calories = 93;
                        break;
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
