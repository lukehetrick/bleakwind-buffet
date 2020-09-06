/* Author: Luke Hetrick
 * Class name: ArentinoAppleJuice.cs
 * Purpose: Class used to represent the Arentino Apple Juice on the menu
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class that represents Arentino Apple juice
    /// </summary>
    public class ArentinoAppleJuice
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
                        price = 0.62;
                        break;
                    case Size.Medium:
                        price = 0.87;
                        break;
                    case Size.Large:
                        price = 1.01;
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
                        calories = 44;
                        break;
                    case Size.Medium:
                        calories = 88;
                        break;
                    case Size.Large:
                        calories = 132;
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
        /// sends the description of this drink based on size
        /// </summary>
        /// <returns>size and label of drink</returns>
        public override string ToString()
        {
            return size.ToString() + " Arentino Apple Juice";
        }

    }
}
