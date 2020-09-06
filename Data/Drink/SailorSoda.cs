/* Author: Luke Hetrick
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent the Sailor soda on the menu
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// class that defines the Sailor Soda object
    /// </summary>
    public class SailorSoda
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

        private SodaFlavor flavor = SodaFlavor.Cherry;
        public SodaFlavor Flavor
        {
            get { return flavor; }
            set { flavor = value; }
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
                switch(size)
                {
                    case Size.Small:
                        price = 1.42;
                        break;
                    case Size.Medium:
                        price = 1.74;
                        break;
                    case Size.Large:
                        price = 2.07;
                        break;
                }
            }
        }


        /// <summary>
        /// provides the get and set values for the calories of the soda.
        /// depends on size of drink
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
                        calories = 117;
                        break;
                    case Size.Medium:
                        calories = 153;
                        break;
                    case Size.Large:
                        calories = 205;
                        break;
                }
            }
        }
        
        /// <summary>
        /// ice value of the drink, default true
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// sends special instructions based on ice property
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                return instructions;
            }
        }


        


        /// <summary>
        /// sends the description of this drink based on size and flavor
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return size.ToString() + " " + flavor.ToString() + " Sailor Soda";
        }

    }
}
