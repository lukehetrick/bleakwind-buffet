/* Author: Luke Hetrick
 * Class name: Menu.cs
 * Purpose: class to statically prepare the menu of the restaurant
 */
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// class to prepare the menu
    /// </summary>
    public static class Menu
    {
        
        
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
            // loop 3 times, once for each size, adding the instances to the list
            List<IOrderItem> sides = new List<IOrderItem>();
            for (int i = 0; i < 3; i++)
            {
                Side wf = new DragonbornWaffleFries();
                wf.Size = (Size)i;
                Side fm = new FriedMiraak();
                fm.Size = (Size)i;
                Side mog = new MadOtarGrits();
                mog.Size = (Size)i;
                Side vs = new VokunSalad();
                vs.Size = (Size)i;

                sides.Add(wf);
                sides.Add(fm);
                sides.Add(mog);
                sides.Add(vs);
                   
            }
            return sides;
        }

        /// <summary>
        /// creates a list of all drinks of all sizes including all the flavors of sailor soda
        /// </summary>
        /// <returns>IEnumerable of all the drinks of all sizes</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            // loop through to initialize each drink each size
            List<IOrderItem> drinks = new List<IOrderItem>();
            for (int i = 0; i < 3; i++)
            {
                Drink aj = new ArentinoAppleJuice();
                aj.Size = (Size)i;
                Drink chc = new CandlehearthCoffee();
                chc.Size = (Size)i;
                Drink mm = new MarkarthMilk();
                mm.Size = (Size)i;
                Drink ww = new WarriorWater();
                ww.Size = (Size)i;

                // loop through to initialize each sailorsoda's flavor within the size
                for (int j = 0; j < 6; j++)
                {
                    SailorSoda ss = new SailorSoda();
                    ss.Size = (Size)i;
                    ss.Flavor = (SodaFlavor)j;
                    drinks.Add(ss);
                }
                drinks.Add(aj);
                drinks.Add(chc);
                drinks.Add(mm);
                drinks.Add(ww);
            }
            return drinks;
        }

        public static IEnumerable<IOrderItem> FullMenu()
        {

            List<IOrderItem> allItems = new List<IOrderItem>() { new BriarheartBurger(), new DoubleDraugr(), new GardenOrcOmelette(),
            new PhillyPoacher(), new SmokehouseSkeleton(), new ThalmoreTriple(), new ThugsTBone() };


            for (int i = 0; i < 3; i++)
            {
                Side wf = new DragonbornWaffleFries();
                wf.Size = (Size)i;
                Side fm = new FriedMiraak();
                fm.Size = (Size)i;
                Side mog = new MadOtarGrits();
                mog.Size = (Size)i;
                Side vs = new VokunSalad();
                vs.Size = (Size)i;

                allItems.Add(wf);
                allItems.Add(fm);
                allItems.Add(mog);
                allItems.Add(vs);

                Drink aj = new ArentinoAppleJuice();
                aj.Size = (Size)i;
                Drink chc = new CandlehearthCoffee();
                chc.Size = (Size)i;
                Drink mm = new MarkarthMilk();
                mm.Size = (Size)i;
                Drink ww = new WarriorWater();
                ww.Size = (Size)i;

                // loop through to initialize each sailorsoda's flavor within the size
                for (int j = 0; j < 6; j++)
                {
                    SailorSoda ss = new SailorSoda();
                    ss.Size = (Size)i;
                    ss.Flavor = (SodaFlavor)j;
                    allItems.Add(ss);
                }
                allItems.Add(aj);
                allItems.Add(chc);
                allItems.Add(mm);
                allItems.Add(ww);
            }


            return allItems;

        }


    }
}
