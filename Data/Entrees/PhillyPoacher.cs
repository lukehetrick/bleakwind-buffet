/*
 * Author: Luke Hetrick
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent the Philly cheese steak sandwich on the menu
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// class to define hte Philly poacher sandwich. Inherits Entree class
    /// </summary>
    public class PhillyPoacher : Entree, IOrderItem, INotifyPropertyChanged
    {       
        /// <value>
        /// price of the sandwich
        /// </value>
        public override double Price => 7.23;

        /// <value>
        /// calorie count of the sandwich
        /// </value>
        public override uint Calories => 784;

        private bool sirloin = true;
        /// <value>
        /// Sirloin get and set value, default true
        /// </value>        
        public bool Sirloin
        {
            get => sirloin;
            set
            {
                if (value != sirloin)
                {
                    sirloin = value;
                    NotifyPropertyChanged("Sirloin");
                    NotifyPropertyChanged("SpecialInstructions");
                }
            }
        }

        private bool onion = true;
        /// <value>
        /// Onion get and set value, default true
        /// </value>        
        public bool Onion
        {
            get => onion;
            set
            {
                if (value != onion)
                {
                    onion = value;
                    NotifyPropertyChanged("Onion");
                    NotifyPropertyChanged("SpecialInstructions");
                }
            }
        }

        private bool roll = true;
        /// <value>
        /// bun get and set value, default true
        /// </value>        
        public bool Roll
        {
            get => roll;
            set
            {
                if (value != roll)
                {
                    roll = value;
                    NotifyPropertyChanged("Roll");
                    NotifyPropertyChanged("SpecialInstructions");
                }
            }
        }

        /// <value>
        /// gets by creating new list based on the bool variables above
        /// </value>
        public override List<string> SpecialInstructions
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
        /// <returns>name of the sandwich: "Philly Poacher"</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
