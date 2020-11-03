
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    public class Combo : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// the property changed event handler for all properties that are changeable
        /// </summary>
        public virtual event PropertyChangedEventHandler PropertyChanged;
        
        private List<string> instructions = new List<string>();

        /// <summary>
        /// Property getter for the private name variable
        /// </summary>
        public string Name
        {
            get => "combo";
        }

        Drink drink;
        Side side;
        Entree entree;
        public Combo(Drink d, Side s, Entree e)
        {
            instructions.Add("[");
            drink = d;
            side = s;
            entree = e;
            PropertyChanged += onPriceChanged;
        }

        public void addDrink(Drink d)
        {
            drink = d;
            PropertyChanged += onPriceChanged;
        }

        public void addSide(Side s)
        {
            side = s;
            PropertyChanged += onPriceChanged;
        }

        public void addEntree(Entree e)
        {
            entree = e;
            PropertyChanged += onPriceChanged;
        }

        private double price;
        public double Price => 0;

        public uint Calories => throw new NotImplementedException();


        
        
        /// <summary>
        /// Special instrucitons for the combo, has name and instrucitons for every item in the combo
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {                
                instructions.Add(drink.ToString());
                instructions.AddRange(drink.SpecialInstructions);
                instructions.Add("]");
                return instructions;
            }
        }

        /// <summary>
        /// when the price is changed invoke property changed 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onPriceChanged(object sender, EventArgs e)
        {
            if (sender is Drink dr) price += dr.Price;

            else if (sender is Side s) price += s.Price;

            else if (sender is Entree en) price += en.Price;
                
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
        }


        /// <summary>
        /// when the price is changed invoke property changed 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onChanged(object sender, EventArgs e)
        {
            if (sender is Drink dr) price += dr.Price;

            else if (sender is Side s) price += s.Price;

            else if (sender is Entree en) price += en.Price;

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
        }
    }
}
