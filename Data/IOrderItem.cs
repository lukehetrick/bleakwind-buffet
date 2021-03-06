﻿/* Author: Luke Hetrick
 * Class name: IOrderItem.cs
 * Purpose: Interface to be a genreic class for all menu items
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// interface for all order items on the menu
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// getter for the Price of the menu item in US dollars
        /// </summary>
        /// <returns>double price of item</returns>
        double Price { get; }

        /// <summary>
        /// getter for the Calorie count of the item
        /// </summary>
        /// <returns>uint Calories</returns>
        uint Calories { get; }

        /// <summary>
        /// getter for the special instructions of the item
        /// </summary>
        /// <returns>List<string> of instrucntions</returns>
        List<string> SpecialInstructions { get; }

        /// <summary>
        /// name of the item
        /// </summary>
        string Name { get; }

        /// <summary>
        /// describes what category of menu item this is, Entree, Side or Drink
        /// </summary>
        string Category { get; }

        /// <summary>
        /// a description of the menu item
        /// </summary>
        string Description { get; }

    }
}
