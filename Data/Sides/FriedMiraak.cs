/* Author: Luke Hetrick
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent Fried Miraak hashbrown pancakes on the menu
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    public class FriedMiraak
    {

        /// <summary>
        /// gets and sets the size of the pancakes. default Small
        /// </summary>
        private Size size = Size.Small;
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }

        /// <summary>
        /// the get for the price of the pancakes
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
                        price = 1.78;
                        break;
                    case Size.Medium:
                        price = 2.01;
                        break;
                    case Size.Large:
                        price = 2.88;
                        break;
                }
            }
        }

        /// <summary>
        /// provides the get and set values for the calories of the pancakes.
        /// depends on the size
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
                        calorie = 151;
                        break;
                    case Size.Medium:
                        calorie = 236;
                        break;
                    case Size.Large:
                        calorie = 306;
                        break;
                }
            }
        }

        /// <summary>
        /// no properties so always returns empty list
        /// </summary>
        public List<string> SpecialInstrucitons
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
        /// <returns></returns>
        public override string ToString()
        {
            return size.ToString() + " Fried Miraak";
        }


    }
}
