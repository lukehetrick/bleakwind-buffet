/*
 * Author: Luke Hetrick
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent the Philly cheese steak sandwich on the menu
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class PhillyPoacher
    {

        /// <summary>
        /// price of the sandwich
        /// </summary>
        public double Price => 7.23;

        /// <summary>
        /// calorie count of the sandwich
        /// </summary>
        public uint Calories => 784;

        /// <summary>
        /// sirloin value, default true
        /// </summary>
        public bool Sirloin { get; set; } = true;

        /// <summary>
        /// onion value, default true
        /// </summary>
        public bool Onion { get; set; } = true;

        /// <summary>
        /// Roll value, default true
        /// </summary>
        public bool Roll { get; set; } = true;



        /// <summary>
        /// gets by creating new list based on the bool variables above
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!Roll) instructions.Add("Hold roll");
                if (!Sirloin) instructions.Add("Hold sirloin");
                if (!Onion) instructions.Add("Hold onion");

                return instructions;
            }
        }

        /// <summary>
        /// sends the name of the sandwich to string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
