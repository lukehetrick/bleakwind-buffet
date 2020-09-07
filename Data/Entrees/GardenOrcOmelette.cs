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
    /// <summary>
    /// Class to define the Garden Orc Omelette
    /// </summary>
    public class GardenOrcOmelette
    {

        /// <value>
        /// price of the omelette
        /// </value>
        public double Price => 4.57;

        /// <value>
        /// calorie count of the omelette
        /// </value>
        public uint Calories => 404;

        /// <value>
        /// Broccoli value, default true
        /// </value>
        public bool Broccoli { get; set; } = true;

        /// <value>
        /// Mushrooms value, default true
        /// </value>
        public bool Mushrooms { get; set; } = true;

        /// <value>
        /// Tomato value, default true
        /// </value>
        public bool Tomato { get; set; } = true;

        /// <value>
        /// Cheddar value, default true
        /// </value>
        public bool Cheddar { get; set; } = true;


        /// <value>
        /// gets by creating new list based on the bool variables above
        /// </value>
        public List<string> SpecialInstructions
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
        /// <returns>name of the omlette: "Garden Orc omelette"</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
