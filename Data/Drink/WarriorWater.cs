/* Author: Luke Hetrick
 * Class name: WarriorWater.cs
 * Purpose: Class used to represent the water on the menu
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drink
{
    public class WarriorWater
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
        /// free for all sizes
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
                        price = 0;
                        break;
                    case Size.Medium:
                        price = 0;
                        break;
                    case Size.Large:
                        price = 0;
                        break;
                }
            }
        }

        /// <summary>
        /// provides the get and set values for the calories of the drink.
        /// 0 for all sizes
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
                        calories = 0;
                        break;
                    case Size.Medium:
                        calories = 0;
                        break;
                    case Size.Large:
                        calories = 0;
                        break;
                }
            }
        }

        /// <summary>
        /// ice value of the drink, default true
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// value of lemon, default false
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// gets instruction list based on ice and lemon variables
        /// </summary>
        public List<string> SpecialInstrucitons
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                if (Lemon) instructions.Add("Add Lemon");
                return instructions;
            }
        }


        /// <summary>
        /// sends the description of this drink based on size
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            
            return size.ToString() + " Warrior Water";
            

        }


    }
}
