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
    /// <summary>
    /// class to define the Smokehouse skeleton breakfast combo. Inherits Entree class
    /// </summary>
    public class SmokehouseSkeleton : Entree, IOrderItem
    {

        /// <value>
        /// price of the combo
        /// </value>
        public override double Price => 5.62;

        /// <value>
        /// number of calories in the combo      
        /// </value>
        public override uint Calories => 602;

        /// <value>
        /// Sasauge link value, default true
        /// </value>
        public bool SausageLink { get; set; } = true;

        /// <value>
        /// Egg value, default true
        /// </value>
        public bool Egg { get; set; } = true;

        /// <value>
        /// HashBrowns value, default true
        /// </value>
        public bool HashBrowns { get; set; } = true;

        /// <value>
        /// Pancake value, default true
        /// </value>
        public bool Pancake { get; set; } = true;

        /// <value>
        /// gets by creating new list based on the bool variables above
        /// </value>
        public override List<string> SpecialInstructions
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
        /// <returns>name fo the combo: "Smokehouse Skeleton"</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
