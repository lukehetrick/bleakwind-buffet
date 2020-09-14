/*
 * Author: Luke Hetrick
 * Class: MenuTests.cs
 * Purpose: Test the Menu.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using System.Collections.Generic;
using System;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class MenuTest
    {
        /// <summary>
        /// test that the Enterss are initialized when Entrees() is called
        /// </summary>
        [Fact]       
        public void EntreesInitialized()
        {
            Assert.Collection<IOrderItem>(Menu.Entrees(), item => Assert.IsType<BriarheartBurger>(item), item => Assert.IsType<DoubleDraugr>(item),
                item => Assert.IsType<GardenOrcOmelette>(item), item => Assert.IsType<PhillyPoacher>(item), item => Assert.IsType<SmokehouseSkeleton>(item),
                item => Assert.IsType<ThalmoreTriple>(item), item => Assert.IsType<ThugsTBone>(item));                
        }

        /// <summary>
        /// tests that the Drinks are initialized when Drinks() is called
        /// </summary>
        [Fact]
        public void DrinksInitialized()
        {
            Assert.Collection<IOrderItem>(Menu.Drinks(), item => Assert.IsType<SailorSoda>(item), item => Assert.IsType<SailorSoda>(item), item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item), item => Assert.IsType<SailorSoda>(item), item => Assert.IsType<SailorSoda>(item), item => Assert.IsType<ArentinoAppleJuice>(item),
                item => Assert.IsType<CandlehearthCoffee>(item), item => Assert.IsType<MarkarthMilk>(item), item => Assert.IsType<WarriorWater>(item),
                //second size of drink
                item => Assert.IsType<SailorSoda>(item), item => Assert.IsType<SailorSoda>(item), item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item), item => Assert.IsType<SailorSoda>(item), item => Assert.IsType<SailorSoda>(item), item => Assert.IsType<ArentinoAppleJuice>(item),
                item => Assert.IsType<CandlehearthCoffee>(item), item => Assert.IsType<MarkarthMilk>(item), item => Assert.IsType<WarriorWater>(item),
                //third size of drink
                item => Assert.IsType<SailorSoda>(item), item => Assert.IsType<SailorSoda>(item), item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item), item => Assert.IsType<SailorSoda>(item), item => Assert.IsType<SailorSoda>(item), item => Assert.IsType<ArentinoAppleJuice>(item),
                item => Assert.IsType<CandlehearthCoffee>(item), item => Assert.IsType<MarkarthMilk>(item), item => Assert.IsType<WarriorWater>(item)
                );
        }

        /// <summary>
        /// Tests that the Sides are properly initialized
        /// </summary>
        [Fact]
        public void SidesInitialized()
        {
            Assert.Collection<IOrderItem>(Menu.Sides(), item => Assert.IsType<DragonbornWaffleFries>(item), item => Assert.IsType<FriedMiraak>(item),
                item => Assert.IsType<MadOtarGrits>(item), item => Assert.IsType<VokunSalad>(item),
                //second size
                item => Assert.IsType<DragonbornWaffleFries>(item), item => Assert.IsType<FriedMiraak>(item),
                item => Assert.IsType<MadOtarGrits>(item), item => Assert.IsType<VokunSalad>(item),
                // third size
                item => Assert.IsType<DragonbornWaffleFries>(item), item => Assert.IsType<FriedMiraak>(item),
                item => Assert.IsType<MadOtarGrits>(item), item => Assert.IsType<VokunSalad>(item));
        }

        /// <summary>
        /// Test that the full menu is initialized
        /// </summary>
        [Fact]
        public void FullMenuInitialized()
        {
            Assert.Collection<IOrderItem>(Menu.FullMenu(),item => Assert.IsType<BriarheartBurger>(item), item => Assert.IsType<DoubleDraugr>(item),
                item => Assert.IsType<GardenOrcOmelette>(item), item => Assert.IsType<PhillyPoacher>(item), item => Assert.IsType<SmokehouseSkeleton>(item),
                item => Assert.IsType<ThalmoreTriple>(item), item => Assert.IsType<ThugsTBone>(item), 
                                
                //Sides
                item => Assert.IsType<DragonbornWaffleFries>(item), item => Assert.IsType<FriedMiraak>(item),
                item => Assert.IsType<MadOtarGrits>(item), item => Assert.IsType<VokunSalad>(item),
                //second size
                item => Assert.IsType<DragonbornWaffleFries>(item), item => Assert.IsType<FriedMiraak>(item),
                item => Assert.IsType<MadOtarGrits>(item), item => Assert.IsType<VokunSalad>(item),
                // third size
                item => Assert.IsType<DragonbornWaffleFries>(item), item => Assert.IsType<FriedMiraak>(item),
                item => Assert.IsType<MadOtarGrits>(item), item => Assert.IsType<VokunSalad>(item),

                //Drinks
                item => Assert.IsType<SailorSoda>(item), item => Assert.IsType<SailorSoda>(item), item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item), item => Assert.IsType<SailorSoda>(item), item => Assert.IsType<SailorSoda>(item), item => Assert.IsType<ArentinoAppleJuice>(item),
                item => Assert.IsType<CandlehearthCoffee>(item), item => Assert.IsType<MarkarthMilk>(item), item => Assert.IsType<WarriorWater>(item),
                //second size of drink
                item => Assert.IsType<SailorSoda>(item), item => Assert.IsType<SailorSoda>(item), item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item), item => Assert.IsType<SailorSoda>(item), item => Assert.IsType<SailorSoda>(item), item => Assert.IsType<ArentinoAppleJuice>(item),
                item => Assert.IsType<CandlehearthCoffee>(item), item => Assert.IsType<MarkarthMilk>(item), item => Assert.IsType<WarriorWater>(item),
                
                //third size
                item => Assert.IsType<SailorSoda>(item), item => Assert.IsType<SailorSoda>(item), item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item), item => Assert.IsType<SailorSoda>(item), item => Assert.IsType<SailorSoda>(item), item => Assert.IsType<ArentinoAppleJuice>(item),
                item => Assert.IsType<CandlehearthCoffee>(item), item => Assert.IsType<MarkarthMilk>(item), item => Assert.IsType<WarriorWater>(item));
        }


    }
}
