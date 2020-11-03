/* Author: Luke Hetrick
 * Class name: ArentinoAppleJuice.cs
 * Purpose: Class used to represent the Arentino Apple Juice on the menu
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;


namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class that represents Arentino Apple juice. Inherits from the Drink class
    /// </summary>
    public class ArentinoAppleJuice : Drink, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Property getter for the private name variable
        /// </summary>
        public override string Name
        {
            get => "Arentino Apple Juice";
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
                    case Size.Small: return 0.62;
                    case Size.Medium: return 0.87;
                    case Size.Large: return 1.01;
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
                    case Size.Small: return 44;                       
                    case Size.Medium: return 88;                        
                    case Size.Large: return 132;
                    default: throw new NotImplementedException("Should never be reached");                      
                }
            }
        }
        

        /// <value>
        /// gets instruction list based on ice request
        /// </value>        
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                return instructions;
            }
        }        


        /// <summary>
        /// sends the description of this drink based on size
        /// </summary>
        /// <returns>size and label of drink</returns>
        public override string ToString()
        {
            return Size.ToString() + " Aretino Apple Juice";
        }

    }
}
