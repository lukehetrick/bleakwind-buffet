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
    public class MarkarthMilk
    {

        /// <summary>
        /// gets and sets the size of the drink. default Small
        /// </summary>
        private Size size = Size.Small;
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }

        

        /// <summary>
        /// the get for the price of the drink
        /// depends on size of drink
        /// </summary>
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


        /// <summary>
        /// provides the get and set values for the calories of the drink.
        /// depends on size of drink
        /// </summary>
        private uint calorie;
        public uint Calorie
        {
            get => calorie;
            set
            {
                switch (size)
                {
                    case Size.Small:
                        calorie = 56;
                        break;
                    case Size.Medium:
                        calorie = 72;
                        break;
                    case Size.Large:
                        calorie = 93;
                        break;
                }
            }
        }
        
        
        /// <summary>
        /// ice value of the drink, default false
        /// </summary>
        public bool Ice { get; set; } = false;

        /// <summary>
        /// gets instruction list based on ice request
        /// </summary>
        public List<string> SpecialInstrucitons
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
        /// <returns></returns>
        public override string ToString()
        {
            return size.ToString() + " Markarth Milk";
        }

    }
}
