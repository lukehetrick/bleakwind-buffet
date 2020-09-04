/* Author: Luke Hetrick
 * Class name: MadOtarGrits.cs
 * Purpose: Class used to represent Mad Otar Grits on the menu
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    public class MadOtarGrits
    {

        /// <summary>
        /// gets and sets the size of the grits. default Small
        /// </summary>
        private Size size = Size.Small;
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }

        /// <summary>
        /// the get for the price of the grits
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
                        price = 1.22;
                        break;
                    case Size.Medium:
                        price = 1.58;
                        break;
                    case Size.Large:
                        price = 1.93;
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
                        calories = 105;
                        break;
                    case Size.Medium:
                        calories = 142;
                        break;
                    case Size.Large:
                        calories = 179;
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
        /// sends the description of the grits based on size
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return size.ToString() + " Mad Otar Grits";
        }


    }
}
