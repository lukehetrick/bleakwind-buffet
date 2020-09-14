/*
 * Author: Luke Hetrick
 * Class name: ThalmoreTriple.cs
 * Purpose: Class used to represent the Thalmor Triple burger on the menu
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// class to define the thalmore triple burger. Inherits Entree class
    /// </summary>
    public class ThalmoreTriple : Entree, IOrderItem
    {
        /// <value>
        /// price of the burger
        /// </value>
        public override double Price
        {
            get { return 8.32; }
        }

        /// <value>
        /// number of calories in the burger      
        /// </value>
        public override uint Calories => 943;


        /// <value>
        /// bun get and set value, default true
        /// </value>        
        public bool Bun { get; set; } = true;

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
        /// Bacon value, default true
        /// </value>
        public bool Bacon { get; set; } = true;

        /// <value>
        /// Egg value, default true
        /// </value>
        public bool Egg { get; set; } = true;

        /// <value>
        /// gets by creating new list based on the bool variables above
        /// </value>
        public override List<string> SpecialInstructions
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
                if (!Bacon) instructions.Add("Hold bacon");
                if (!Egg) instructions.Add("Hold egg");

                return instructions;
            }
        }

        /// <summary>
        /// sends the name of the burger to string
        /// </summary>
        /// <returns>name of the burger: "Thalmore Triple"</returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}
