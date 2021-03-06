﻿/*
 * Author: Luke Hetrick
 * Class name: GardenOrcOmelette.cs
 * Purpose: Class used to represent the GardenOrcOmelette Vegetarian omlet on the menu
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class to define the Garden Orc Omelette. Inherits Entree class
    /// </summary>
    public class GardenOrcOmelette : Entree, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// provides a description of the item
        /// </summary>
        public override string Description => "Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese.";

        /// <summary>
        /// Property getter for the private name variable
        /// </summary>
        public override string Name
        {
            get => "Garden Orc Omelette";
        }

        /// <value>
        /// price of the omelette
        /// </value>
        public override double Price => 4.57;

        /// <value>
        /// calorie count of the omelette
        /// </value>
        public override uint Calories => 404;

        private bool broccoli = true;
        /// <value>
        /// Broccoli get and set value, default true
        /// </value>        
        public bool Broccoli
        {
            get => broccoli;
            set
            {
                if (value != broccoli)
                {
                    broccoli = value;
                    NotifyPropertyChanged("Broccoli");
                    NotifyPropertyChanged("SpecialInstructions");
                }
            }
        }

        private bool mushrooms = true;
        /// <value>
        /// Mushroom get and set value, default true
        /// </value>        
        public bool Mushrooms
        {
            get => mushrooms;
            set
            {
                if (value != mushrooms)
                {
                    mushrooms = value;
                    NotifyPropertyChanged("Mushrooms");
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

        private bool cheddar = true;
        /// <value>
        /// Cheddar value, default true
        /// </value>
        public bool Cheddar
        {
            get => cheddar;
            set
            {
                if (value != cheddar)
                {
                    cheddar = value;
                    NotifyPropertyChanged("Cheddar"); 
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

                if (!Broccoli) instructions.Add("Hold broccoli");
                if (!Mushrooms) instructions.Add("Hold mushrooms");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Cheddar) instructions.Add("Hold cheddar");

                return instructions;
            }
        }

        /// <summary>
        /// sends the name of the omelette to string
        /// </summary>
        /// <returns>name of the omlette: "Garden Orc omelette"</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
