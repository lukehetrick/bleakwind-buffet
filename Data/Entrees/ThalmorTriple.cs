/*
 * Author: Luke Hetrick
 * Class name: ThalmoreTriple.cs
 * Purpose: Class used to represent the Thalmor Triple burger on the menu
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// class to define the thalmore triple burger. Inherits Entree class
    /// </summary>
    public class ThalmoreTriple : Entree, IOrderItem, INotifyPropertyChanged
    {        
        /// <value>
        /// price of the burger
        /// </value>
        public override double Price
        {
            get { return 8.32; }
        }

        /// <value>
        /// number of calories in the burger      
        /// </value>
        public override uint Calories => 943;


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

        private bool tomato = true;
        /// <value>
        /// tomato value, default true
        /// </value>
        public bool Tomato
        {
            get => tomato;
            set
            {
                if (value != tomato)
                {
                    tomato = value;
                    NotifyPropertyChanged("Tomato");
                    NotifyPropertyChanged("SpecialInstructions");
                }
            }
        }

        private bool lettuce = true;
        /// <value>
        /// Lettuce value, default true
        /// </value>
        public bool Lettuce
        {
            get => lettuce;
            set
            {
                if (value != lettuce)
                {
                    lettuce = value;
                    NotifyPropertyChanged("Lettuce");
                    NotifyPropertyChanged("SpecialInstructions");
                }
            }
        }

        private bool mayo = true;
        /// <value>
        /// Mayo value, default true
        /// </value>
        public bool Mayo
        {
            get => mayo;
            set
            {
                if (value != mayo)
                {
                    mayo = value;
                    NotifyPropertyChanged("Mayo");
                    NotifyPropertyChanged("SpecialInstructions");
                }
            }
        }

        private bool bacon = true;
        /// <value>
        /// Bacon value, default true
        /// </value>
        public bool Bacon
        {
            get => bacon;
            set
            {
                if (value != bacon)
                {
                    bacon = value;
                    NotifyPropertyChanged("Bacon");
                    NotifyPropertyChanged("SpecialInstructions");
                }
            }
        }

        private bool egg = true;
        /// <value>
        /// Mayo value, default true
        /// </value>
        public bool Egg
        {
            get => egg;
            set
            {
                if (value != egg)
                {
                    egg = value;
                    NotifyPropertyChanged("Egg");
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
        /// <returns>name of the burger: "Thalmore Triple"</returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}
