/* Author: Luke Hetrick
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Class used to represent Dragonborn Waffle Fries on the menu
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    public class DragonbornWaffleFries
    {

        /// <summary>
        /// gets and sets the size of the fries. default Small
        /// </summary>
        private Size size = Size.Small;
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }

        /// <summary>
        /// the get for the price of the fries
        /// depends on the size
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
                        price = .42;
                        break;
                    case Size.Medium:
                        price = .76;
                        break;
                    case Size.Large:
                        price = .96;
                        break;
                }
            }
        }

        /// <summary>
        /// provides the get and set values for the calories of the grits.
        /// depends on the size
        /// </summary>
        private uint calories;
        public uint Calories
        {
            get => calories;
            set
            {
                switch (size)
                {
                    case Size.Small:
                        calories = 77;
                        break;
                    case Size.Medium:
                        calories = 89;
                        break;
                    case Size.Large:
                        calories = 100;
                        break;
                }
            }
        }

        /// <summary>
        /// no properties so always returns empty list
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }


        /// <summary>
        /// sends the description of the fries based on size
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return size.ToString() + " Dragonborn Waffle Fries";
        }


    }
}
