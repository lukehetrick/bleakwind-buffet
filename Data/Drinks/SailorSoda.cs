/* Author: Luke Hetrick
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent the Sailor soda on the menu
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// class that defines the Sailor Soda object. Inherits from the Drink class
    /// </summary>
    public class SailorSoda : Drink, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Property getter for the private name variable
        /// </summary>
        public override string Name
        {
            get => "Sailor Soda";
        }


        private SodaFlavor flavor = SodaFlavor.Cherry;
        /// <value>
        /// value for the flavor of drink, default Cherry
        /// </value>
        public SodaFlavor Flavor
        {
            get => flavor;
            set
            {
                if (value != flavor)
                {
                    flavor = value;
                    NotifyPropertyChanged("Flavor");
                }
            }
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
                    case Size.Small: return 1.42;
                    case Size.Medium: return 1.74;
                    case Size.Large: return 2.07;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }            
        }


        /// <value>
        /// provides the get and set values for the calories of the soda.
        /// depends on size of drink
        /// </value>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 117;
                    case Size.Medium: return 153;
                    case Size.Large: return 205;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }            
        }

        private bool ice = true;
        /// <value>
        /// ice value of the drink, default false
        /// </value>
        public override bool Ice
        {
            get => ice;
            set
            {
                if (value != ice)
                {
                    ice = value;
                    NotifyPropertyChanged("Ice");
                    NotifyPropertyChanged("SpecialInstructions");
                }
            }
        }

        /// <value>
        /// sends special instructions based on ice property
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                return instructions;
            }
        }


        /// <summary>
        /// sends the description of this drink based on size and flavor
        /// </summary>
        /// <returns>description of drink including size and flavor</returns>
        public override string ToString()
        {
            return Size.ToString() + " " + Flavor.ToString() + " Sailor Soda";
        }

    }
}
