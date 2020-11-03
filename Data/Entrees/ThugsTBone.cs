/*
 * Author: Luke Hetrick
 * Class name: ThugsTBone.cs
 * Purpose: Class used to represent the T-bone on the menu
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// class to define the Thugs T-bone. Inherits Entree class
    /// </summary>
    public class ThugsTBone : Entree, IOrderItem, INotifyPropertyChanged
    {

        /// <summary>
        /// Property getter for the private name variable
        /// </summary>
        public override string Name
        {
            get => "Thugs T-Bone";
        }

        /// <value>
        /// price of the T-Bone
        /// </value>
        public override double Price => 6.44;

        /// <value>
        /// calorie count of the T-Bone
        /// </value>
        public override uint Calories => 982;


        /// <value>
        /// no properties so always returns empty list
        /// </value>
        public override List<string> SpecialInstructions
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
        /// <returns>name of the steak: "Thugs T-Bone"</returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }


    }
}
