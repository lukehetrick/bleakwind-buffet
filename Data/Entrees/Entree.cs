﻿/* Author: Luke Hetrick
 * Class name: Entree.cs
 * Purpose: Entree base class for entree classes to inherit properties of
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Entrees
{
    public abstract class Entree : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// describes what category of item this is (Entree, Side or Drink)
        /// </summary>
        public string Category => "Entree";

        /// <summary>
        /// description of the item
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// the property changed event handler for all properties that are changeable
        /// </summary>
        public virtual event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// abstract price because it will need to be overrideen for every class
        /// only needs get.
        /// </summary>
        /// <value>
        /// in US dollars
        /// </value>
        public abstract double Price { get; }

        /// <summary>
        /// abstract calroies because it will need to be overrideen for every class
        /// only needs get
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// special instructions to prepare the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// Property that returns the name of the drink
        /// </summary>
        public abstract string Name { get; }
    }
}
