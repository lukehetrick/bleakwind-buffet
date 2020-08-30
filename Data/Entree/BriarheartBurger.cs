/*
 * Author: Luke Hetrick
 * Class name: BriarHeartBurger.cs
 * Purpose: Class used to represent the BriarheartBurger on the menu
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class BriarheartBurger
    {
        /// <summary>
        /// price of the burger
        /// </summary>
        public double Price
        {
            get { return 6.32; }
        }

        /// <summary>
        /// number of calories in the burger
        /// </summary>
        public uint Calories => 742;


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
                return instrucitons;
            }
        }

        /// <summary>
        /// sends the name of the burger to string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
