/*
 * Author: Luke Hetrick
 * Class name: ThalmoreTriple.cs
 * Purpose: Class used to represent the TripleThalmor burger on the menu
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThalmoreTriple
    {
        /// <summary>
        /// price of the burger
        /// </summary>
        public double Price
        {
            get { return 8.32; }
        }

        /// <summary>
        /// number of calories in the burger        //I was experimenting with the different get/set options
        /// </summary>
        public uint Calories => 943;


        /// <summary>
        /// bun get and set value, default true
        /// </summary>
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

        /// <summary>
        /// ketchup value, default true
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// Mustard value, default true
        /// </summary>
        public bool Mustard { get; set; } = true;


        /// <summary>
        /// Pickle value, default true
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// Cheese value, default true
        /// </summary>
        public bool Cheese { get; set; } = true;


        /// <summary>
        /// Tomato value, default true
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// Lettuce value, default true
        /// </summary>        
        public bool Lettuce { get; set; } = true;

        /// <summary>
        /// Mayo value, default true
        /// </summary>
        public bool Mayo { get; set; } = true;

        /// <summary>
        /// Bacon value, default true
        /// </summary>
        public bool Bacon { get; set; } = true;

        /// <summary>
        /// Egg value, default true
        /// </summary>
        public bool Egg { get; set; } = true;


        /// <summary>
        /// gets by creating new list based on the bool variables above
        /// </summary>
        public List<string> SpecialInstrucitons
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
        /// <returns></returns>
        public override string ToString()
        {
            return "Thalmore Triple";
        }
    }
}
