﻿/* Author: Luke Hetrick
 * Class name: WarriorWater.cs
 * Purpose: Class used to represent the water on the menu
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// class to define warrior water object. Inherits from Drink class
    /// </summary>
    public class WarriorWater : Drink, IOrderItem
    {
               
        /// <value>
        /// the get for the price of the drink
        /// free for all sizes
        /// </value>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 0;
                    case Size.Medium: return 0;
                    case Size.Large: return 0;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }            
        }

        /// <value>
        /// provides the get and set values for the calories of the drink.
        /// 0 for all sizes
        /// </value>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 0;
                    case Size.Medium: return 0;
                    case Size.Large: return 0;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }            
        }

        /// <value>
        /// ice value of the drink, default true
        /// </value>
        public bool Ice { get; set; } = true;

        /// <value>
        /// value of lemon, default false
        /// </value>
        public bool Lemon { get; set; } = false;

        /// <value>
        /// gets instruction list based on ice and lemon variables
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                if (Lemon) instructions.Add("Add lemon");
                return instructions;
            }
        }


        /// <summary>
        /// sends the description of this drink based on size
        /// </summary>
        /// <returns>description of size and drink</returns>
        public override string ToString()
        {
            return Size.ToString() + " Warrior Water";            
        }


    }
}