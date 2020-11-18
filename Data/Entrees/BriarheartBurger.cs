/*
 * Author: Luke Hetrick
 * Class name: BriarHeartBurger.cs
 * Purpose: Class used to represent the BriarheartBurger on the menu
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class for briarheart burger. Inherits Entree class
    /// </summary>
    public class BriarheartBurger : Entree, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// provides a description of the item
        /// </summary>
        public override string Description => "Single patty burger on a brioche bun. Comes with ketchup, mustard, pickle, and cheese.";

        /// <summary>
        /// Property getter for the private name variable
        /// </summary>
        public override string Name
        {
            get => "Briarheart Burger";
        }

        /// <value>
        /// price of the burger
        /// </value>
        public override double Price
        {
            get { return 6.32; }
        }

        /// <value>
        /// number of calories in the burger
        /// </value>
        public override uint Calories => 743;


        private bool bun = true;
        /// <value>
        /// bun get and set value, default true
        /// </value>        
        public bool Bun
        {
            get => bun;
            set
            {
                if (value != bun)
                {
                    bun = value;
                    NotifyPropertyChanged("Bun");
                    NotifyPropertyChanged("SpecialInstructions");
                }
            }
        }

        private bool ketchup = true;
        /// <value>
        /// ketchup value, default true
        /// </value>
        public bool Ketchup
        {
            get => ketchup;
            set
            {
                if (value != ketchup)
                {
                    ketchup = value;
                    NotifyPropertyChanged("Ketchup");
                    NotifyPropertyChanged("SpecialInstructions");
                }
            }
        }

        private bool mustard = true;
        /// <value>
        /// Mustard value, default true
        /// </value>
        public bool Mustard
        {
            get => mustard;
            set
            {
                if (value != mustard)
                {
                    mustard = value;
                    NotifyPropertyChanged("Mustard");
                    NotifyPropertyChanged("SpecialInstructions");
                }
            }
        }


        private bool pickle = true;
        /// <value>
        /// Pickle value, default true
        /// </value>
        public bool Pickle
        {
            get => pickle;
            set
            {
                if (value != pickle)
                {
                    pickle = value;
                    NotifyPropertyChanged("Pickle"); 
                    NotifyPropertyChanged("SpecialInstructions");
                }
            }
        }

        private bool cheese = true;
        /// <value>
        /// Cheese value, default true
        /// </value>
        public bool Cheese
        {
            get => cheese;
            set
            {
                if (value != cheese)
                {
                    cheese = value;
                    NotifyPropertyChanged("Cheese");
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
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");
                return instructions;
            }
        }

        /// <summary>
        /// sends the name of the burger to string
        /// </summary>
        /// <returns>name of burger: "Briarheart Burger"</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
