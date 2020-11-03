/* Author: Luke Hetrick
 * Class name: CandlehearthCoffee.cs
 * Purpose: Class used to represent the Candlehearth Coffee on the menu
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class to contain Candle hearth coffee. Inherits from the Drink class
    /// </summary>
    public class CandlehearthCoffee : Drink, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// the property changed event handler for all properties that are changeable
        /// </summary>
       // public override event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Property getter for the private name variable
        /// </summary>
        public override string Name
        {
            get => "Candlehearth Coffee";
        }

        /// <value>
        /// the get for the price of the drink
        /// depends on size of drink
        /// </value>        
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 0.75;
                    case Size.Medium: return 1.25;
                    case Size.Large: return 1.75;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }            
        }

        /// <value>
        /// provides the get and set values for the calories of the drink.
        /// depends on size of drink
        /// </value>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 7;
                    case Size.Medium: return 10;
                    case Size.Large: return 20;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }
        }


        private bool roomforcream = false;
        /// <value>
        /// Room for cream value of the drink, default false
        /// </value>
        public virtual bool RoomForCream
        {
            get => roomforcream;
            set
            {
                if (value != roomforcream)
                {
                    roomforcream = value;

                    NotifyPropertyChanged("RoomForCream");
                    NotifyPropertyChanged("SpecialInstructions");
                }
            }
        }

        private bool decaf = false;
        /// <value>
        /// ice value of the drink, default false
        /// </value>
        public virtual bool Decaf
        {
            get => decaf;
            set
            {
                if (value != decaf)
                {
                    decaf = value;
                    NotifyPropertyChanged("Decaf");
                    NotifyPropertyChanged("SpecialInstructions");                   
                }
            }
        }

        /// <value>
        /// gets instruction list based on ice and cream variables
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                if (RoomForCream) instructions.Add("Add cream");                
                return instructions;
            }
        }


        /// <summary>
        /// sends the description of this drink based on size and caffine
        /// </summary>
        /// <returns>string with label for decaf and size of drink</returns>
        public override string ToString()
        {
            if(Decaf)
            {
                return Size.ToString() + " Decaf Candlehearth Coffee";
            }
            else
            {
                return Size.ToString() + " Candlehearth Coffee";
            }
            
        }

    }
}
