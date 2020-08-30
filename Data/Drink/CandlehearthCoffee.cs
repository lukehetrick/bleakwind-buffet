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
    public class CandlehearthCoffee
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
                        calorie = 7;
                        break;
                    case Size.Medium:
                        calorie = 10;
                        break;
                    case Size.Large:
                        calorie = 20;
                        break;
                }
            }
        }


        /// <summary>
        /// ice value of the drink, default false
        /// </summary>
        public bool Ice { get; set; } = false;

        /// <summary>
        /// value for room for cream in the coffee, default false
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// value for decaf coffee, default false
        /// </summary>
        public bool Decaf { get; set; } = false;

        /// <summary>
        /// gets instruction list based on ice and cream variables
        /// </summary>
        public List<string> SpecialInstrucitons
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
        /// <returns></returns>
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
