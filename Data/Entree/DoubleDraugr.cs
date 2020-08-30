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
    public class DoubleDraugr
    {
        /// <summary>
        /// price of the burger
        /// </summary>
        public double Price
        {
            get { return 7.32; }
        }

        /// <summary>
        /// number of calories in the burger        //I was experimenting with the different get/set options
        /// </summary>
        public uint Calories => 843;


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
        /// gets by creating new list based on the bool variables above
        /// </summary>
        public List<string> SpecialInstrucitons
        {
            get
            {
                List<string> instrucitons = new List<string>();
                if (!Bun) instrucitons.Add("Hold bun");
                if (!Ketchup) instrucitons.Add("Hold ketchup");
                if (!Mustard) instrucitons.Add("Hold mustard");
                if (!Pickle) instrucitons.Add("Hold pickle");
                if (!Cheese) instrucitons.Add("Hold cheese");
                if (!Tomato) instrucitons.Add("Hold tomato");
                if (!Lettuce) instrucitons.Add("Hold lettuce");
                if (!Mayo) instrucitons.Add("Hold mayo");

                return instrucitons;
            }
        }

        /// <summary>
        /// sends the name of the burger to string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "DoubleDragr";
        }
    }
}
