/* Author: Luke Hetrick
 * Class name: VokunSalad.cs
 * Purpose: Class used to represent Vokun Salad on the menu
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    public class VokunSalad
    {

        /// <summary>
        /// gets and sets the size of the salad. default Small
        /// </summary>
        private Size size = Size.Small;
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }

        /// <summary>
        /// the get for the price of the salad
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
                        price = 0.93;
                        break;
                    case Size.Medium:
                        price = 1.28;
                        break;
                    case Size.Large:
                        price = 1.82;
                        break;
                }
            }
        }

        /// <summary>
        /// provides the get and set values for the calories of the salad.
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
                        calorie = 41;
                        break;
                    case Size.Medium:
                        calorie = 52;
                        break;
                    case Size.Large:
                        calorie = 73;
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
        /// sends the description of the salad based on size
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return size.ToString() + " Vokun Salad";
        }


    }
}
