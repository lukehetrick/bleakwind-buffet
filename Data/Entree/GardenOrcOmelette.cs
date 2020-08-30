/*
 * Author: Luke Hetrick
 * Class name: GardenOrcOmelette.cs
 * Purpose: Class used to represent the GardenOrcOmelette Vegetarian omlet on the menu
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class GardenOrcOmelette
    {

        /// <summary>
        /// price of the omelette
        /// </summary>
        public double Price => 4.57;

        /// <summary>
        /// calorie count of the omelette
        /// </summary>
        public uint Calories => 404;

        /// <summary>
        /// Broccoli value, default true
        /// </summary>
        public bool Broccoli { get; set; } = true;

        /// <summary>
        /// Mushrooms value, default true
        /// </summary>
        public bool Mushrooms { get; set; } = true;

        /// <summary>
        /// Tomato value, default true
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// Cheddar value, default true
        /// </summary>
        public bool Cheddar { get; set; } = true;


        /// <summary>
        /// gets by creating new list based on the bool variables above
        /// </summary>
        public List<string> SpecialInstrucitons
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!Broccoli) instructions.Add("Hold broccoli");
                if (!Mushrooms) instructions.Add("Hold mushrooms");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Cheddar) instructions.Add("Hold cheddar");

                return instructions;
            }
        }

        /// <summary>
        /// sends the name of the omelette to string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
