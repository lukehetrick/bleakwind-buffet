﻿/* Author: Luke Hetrick
 * Class name: Menu.cs
 * Purpose: class to statically prepare the menu of the restaurant
 */
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// class to prepare the menu
    /// </summary>
    public static class Menu
    {
        public static string[] Category
        {
            get => new string[]
            {
                "Entree",
                "Drink",
                "Side"
            };
        }
       
        
        /// <summary>
        /// create an instance of all entrees
        /// </summary>
        /// <returns>IEnumerable containing all instances of all available entrees</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entrees = new List<IOrderItem>() { new BriarheartBurger(), new DoubleDraugr(), new GardenOrcOmelette(),
            new PhillyPoacher(), new SmokehouseSkeleton(), new ThalmoreTriple(), new ThugsTBone() };
            return entrees;
        }

        /// <summary>
        /// creates an instance of all sides in all sizes
        /// </summary>
        /// <returns>IEnumerable of all sides of all sizes</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            //prepare small instances of each and add them to the list
            /*Side swf = new DragonbornWaffleFries();
            swf.Size = Size.Small;
            Side sfm = new FriedMiraak();
            sfm.Size = Size.Small;
            Side smog = new MadOtarGrits();
            smog.Size = Size.Small;
            Side svs = new VokunSalad();
            svs.Size = Size.Small;
            List<IOrderItem> sides = new List<IOrderItem>() { swf, sfm, smog, svs };

            */
            
            List<IOrderItem> sides = new List<IOrderItem>();

            foreach (Size s in Enum.GetValues(typeof(Size)))
            {
                sides.Add(new DragonbornWaffleFries()
                {
                    Size = s
                });

                sides.Add(new FriedMiraak()
                {
                    Size = s
                });

                sides.Add(new MadOtarGrits()
                {
                    Size = s
                });

                sides.Add(new VokunSalad()
                {
                    Size = s
                });
            }

            return sides;
        }

        /// <summary>
        /// creates an instance of all sides without size distction
        /// </summary>
        /// <returns>IEnumerable of all sides without size distiction</returns>
        public static IEnumerable<IOrderItem> SideList()
        {
            List<IOrderItem> sides = new List<IOrderItem>();

            sides.Add(new DragonbornWaffleFries());
            sides.Add(new FriedMiraak());
            sides.Add(new MadOtarGrits());
            sides.Add(new VokunSalad());            

            return sides;
        }

        /// <summary>
        /// creates an instance of all drinks without size distction
        /// </summary>
        /// <returns>IEnumerable of all drinks without size distiction</returns>
        public static IEnumerable<IOrderItem> DrinkList()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();

            drinks.Add(new ArentinoAppleJuice());
            drinks.Add(new CandlehearthCoffee());
            drinks.Add(new MarkarthMilk());
            drinks.Add(new WarriorWater());
            drinks.Add(new SailorSoda());
            return drinks;
        }

        /// <summary>
        /// creates a list of all drinks of all sizes including all the flavors of sailor soda
        /// </summary>
        /// <returns>IEnumerable of all the drinks of all sizes</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();

            foreach (Size s in Enum.GetValues(typeof(Size)))
            {
                drinks.Add(new ArentinoAppleJuice()
                {
                    Size = s
                });

                drinks.Add(new CandlehearthCoffee()
                {
                    Size = s
                });

                drinks.Add(new MarkarthMilk()
                {
                    Size = s
                });

                drinks.Add(new SailorSoda()
                {
                    Size = s
                });

                drinks.Add(new WarriorWater()
                {
                    Size = s
                });
            }

            return drinks;
        }

        /// <summary>
        /// creates the whole menu using the methods Entrees(), Sides(), and Drinks()
        /// </summary>
        /// <returns>complete menu</returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> allItems = new List<IOrderItem>();
            allItems.AddRange(Entrees());
            allItems.AddRange(Sides());
            allItems.AddRange(Drinks());

            return allItems;

        }

        /// <summary>
        /// the whole menu in one list
        /// </summary>
        public static IEnumerable<IOrderItem> ALL { get { return FullMenu(); } }

        public static IEnumerable<IOrderItem> Search(string terms)
        {
            if (terms == null) return ALL;
            
            List<IOrderItem> results = new List<IOrderItem>();
            
            terms = terms.ToLower();
            foreach(IOrderItem item in ALL)
            {
                if(item.Name.ToLower().Contains(terms))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// filters the given list of items by the category checked 
        /// </summary>
        /// <param name="givenItems">IEnumerable<IOrderItem> of the current list of items being filtered</param>
        /// <param name="categroy">the category of item to include</param>
        /// <returns>A collection containing only the items that match the filter</returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> givenItems, IEnumerable<string> categroy)
        {
            if (categroy == null || categroy.Count() == 0) return givenItems;

            List<IOrderItem> results = new List<IOrderItem>();

            foreach(IOrderItem item in givenItems)
            {
                if(categroy.Contains(item.Category))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the provided collection of menu items
        /// to those with price falling within
        /// the specified range
        /// </summary>
        /// <param name="givenItems">The collection of movies to filter</param>
        /// <param name="min">The minimum range value</param>
        /// <param name="max">The maximum range value</param>
        /// <returns>The filtered menu item collection</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> givenItems, double? min, double? max)
        {
            var results = new List<IOrderItem>();

            if (min == null && max == null) return givenItems;

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in givenItems)
                {
                    if (item.Price <= max) results.Add(item);
                }
                return results;
            }

            // only a minimum specified
            if (max == null)
            {
                foreach (IOrderItem item in givenItems)
                {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }

            // Both minimum and maximum specified
            foreach (IOrderItem item in givenItems)
            {
                if (item.Price >= min && item.Price <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the provided collection of menu items
        /// to those with Calories falling within
        /// the specified range
        /// </summary>
        /// <param name="givenItems">The collection of movies to filter</param>
        /// <param name="min">The minimum range value</param>
        /// <param name="max">The maximum range value</param>
        /// <returns>The filtered menu item collection</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> givenItems, double? min, double? max)
        {
            var results = new List<IOrderItem>();

            if (min == null && max == null) return givenItems;

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in givenItems)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }

            // only a minimum specified
            if (max == null)
            {
                foreach (IOrderItem item in givenItems)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }

            // Both minimum and maximum specified
            foreach (IOrderItem item in givenItems)
            {
                if (item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }

    }
}
