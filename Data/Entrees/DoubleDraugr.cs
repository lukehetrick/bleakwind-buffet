/*
 * Author: Luke Hetrick
 * Class name: DoubleDraugr.cs
 * Purpose: Class used to represent the DoubleDraugr burger on the menu
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// class to defne the doulbe draugr burger
    /// </summary>
    public class DoubleDraugr
    {
        /// <value>
        /// price of the burger
        /// </value>
        public double Price
        {
            get { return 7.32; }
        }

        /// <value>
        /// number of calories in the burger        //I was experimenting with the different get/set options
        /// </value>
        public uint Calories => 843;


        /// <value>
        /// bun get and set value, default true
        /// </value>
        private bool bun = true;
        public bool Bun
        {
            get
            {
                return bun;
            }
            set
            {
                bun = value;
            }
        }

        /// <value>
        /// ketchup value, default true
        /// </value>
        public bool Ketchup { get; set; } = true;

        /// <value>
        /// Mustard value, default true
        /// </value>
        public bool Mustard { get; set; } = true;


        /// <value>
        /// Pickle value, default true
        /// </value>
        public bool Pickle { get; set; } = true;

        /// <value>
        /// Cheese value, default true
        /// </value>
        public bool Cheese { get; set; } = true;


        /// <value>
        /// Tomato value, default true
        /// </value>
        public bool Tomato { get; set; } = true;

        /// <value>
        /// Lettuce value, default true
        /// </value>        
        public bool Lettuce { get; set; } = true;

        /// <value>
        /// Mayo value, default true
        /// </value>
        public bool Mayo { get; set; } = true;


        /// <value>
        /// gets by creating new list based on the bool variables above
        /// </value>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Lettuce) instructions.Add("Hold lettuce");
                if (!Mayo) instructions.Add("Hold mayo");

                return instructions;
            }
        }

        /// <summary>
        /// sends the name of the burger to string
        /// </summary>
        /// <returns>name of burger: "Doulbe Draugr"</returns>
        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}
