/*
 * Author: Luke Hetrick
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent the SmokehouseSkeleton breakfast combo on the menu
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class SmokehouseSkeleton
    {

        /// <summary>
        /// price of the combo
        /// </summary>
        public double Price => 5.62;

        /// <summary>
        /// number of calories in the combo      
        /// </summary>
        public uint Calories => 602;

        /// <summary>
        /// Sasauge link value, default true
        /// </summary>
        public bool SausageLink { get; set; } = true;

        /// <summary>
        /// Egg value, default true
        /// </summary>
        public bool Egg { get; set; } = true;

        /// <summary>
        /// HashBrowns value, default true
        /// </summary>
        public bool HashBrowns { get; set; } = true;

        /// <summary>
        /// Pancake value, default true
        /// </summary>
        public bool Pancake { get; set; } = true;


        /// <summary>
        /// gets by creating new list based on the bool variables above
        /// </summary>
        public List<string> SpecialInstrucitons
        {
            get
            {
                List<string> instructions = new List<string>();
               
                if (!HashBrowns) instructions.Add("Hold hash browns");
                if (!SausageLink) instructions.Add("Hold sausage");
                if (!Pancake) instructions.Add("Hold pancakes");
                if (!Egg) instructions.Add("Hold eggs");

                return instructions;
            }
        }

        /// <summary>
        /// sends the name of the combo to string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
