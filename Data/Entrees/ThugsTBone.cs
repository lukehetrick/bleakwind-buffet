/*
 * Author: Luke Hetrick
 * Class name: ThugsTBone.cs
 * Purpose: Class used to represent the T-bone on the menu
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThugsTBone
    {
        
        /// <summary>
        /// price of the T-Bone
        /// </summary>
        public double Price => 6.44;

        /// <summary>
        /// calorie count of the T-Bone
        /// </summary>
        public uint Calories => 982;


        /// <summary>
        /// no properties so always returns empty list
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                return instructions;
            }
        }

        /// <summary>
        /// sends the name of the T-Bone to string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
