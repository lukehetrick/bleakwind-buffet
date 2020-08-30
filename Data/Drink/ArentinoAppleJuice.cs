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
    public class ArentinoAppleJuice
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
                        calorie = 44;
                        break;
                    case Size.Medium:
                        calorie = 88;
                        break;
                    case Size.Large:
                        calorie = 132;
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
        /// sends the description of this drink based on size
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return size.ToString() + " Arentino Apple Juice";
        }

    }
}
