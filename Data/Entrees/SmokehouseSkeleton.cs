/*
 * Author: Luke Hetrick
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent the SmokehouseSkeleton breakfast combo on the menu
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// class to define the Smokehouse skeleton breakfast combo. Inherits Entree class
    /// </summary>
    public class SmokehouseSkeleton : Entree, IOrderItem, INotifyPropertyChanged
    {

        /// <summary>
        /// provides a description of the item
        /// </summary>
        public override string Description => "Put some meat on those bones with a small stack of pancakes. Includes sausage links, " +
            "eggs, and hash browns on the side. Topped with the syrup of your choice.";


        /// <summary>
        /// Property getter for the private name variable
        /// </summary>
        public override string Name
        {
            get => "Smokehouse Skeleton";
        }

        /// <value>
        /// price of the combo
        /// </value>
        public override double Price => 5.62;

        /// <value>
        /// number of calories in the combo      
        /// </value>
        public override uint Calories => 602;

        private bool sausageLink = true;
        /// <value>
        /// Sausage Link get and set value, default true
        /// </value>        
        public bool SausageLink
        {
            get => sausageLink;
            set
            {
                if (value != sausageLink)
                {
                    sausageLink = value;
                    NotifyPropertyChanged("SausageLink");
                    NotifyPropertyChanged("SpecialInstructions");
                }
            }
        }

        private bool egg = true;
        /// <value>
        /// Egg get and set value, default true
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

        private bool hashbrowns = true;
        /// <value>
        /// Hash browns get and set value, default true
        /// </value>        
        public bool HashBrowns
        {
            get => hashbrowns;
            set
            {
                if (value != hashbrowns)
                {
                    hashbrowns = value;
                    NotifyPropertyChanged("HashBrowns");
                    NotifyPropertyChanged("SpecialInstructions");
                }
            }
        }

        private bool pancake = true;
        /// <value>
        /// pancake get and set value, default true
        /// </value>        
        public bool Pancake
        {
            get => pancake;
            set
            {
                if (value != pancake)
                {
                    pancake = value;
                    NotifyPropertyChanged("Pancake");
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
