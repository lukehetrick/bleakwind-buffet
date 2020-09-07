/* Author: Luke Hetrick
 * Class name: ArentinoAppleJuice.cs
 * Purpose: Class used to represent the Arentino Apple Juice on the menu
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;


namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class that represents Arentino Apple juice
    /// </summary>
    public class ArentinoAppleJuice
    {

        /// <value>
        /// gets and sets the size of the drink. default Small
        /// </value>
        private Size size = Size.Small;
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }

        /// <value>
        /// the get for the price of the drink
        /// depends on size of drink
        /// </value>
        public double Price
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
        public uint Calories
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
        /// ice value of the drink, default false
        /// </value>
        public bool Ice { get; set; } = false;

        /// <value>
        /// gets instruction list based on ice request
        /// </value>        
        public List<string> SpecialInstructions
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
            return size.ToString() + " Aretino Apple Juice";
        }

    }
}
