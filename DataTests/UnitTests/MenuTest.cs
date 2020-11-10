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
using System.Linq;

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
        /// tests that the Drinks are initialized when Drinks() is called, taken from the TA solution
        /// </summary>
        [Fact]
        public void DrinksInitialized()
        {
            /* Aretino Apple Juice */
            bool includesSmallAAJ = false;
            bool includesMedAAJ = false;
            bool includesLarAAJ = false;

            /* Candlehearth Coffee */
            bool includesSmallCC = false;
            bool includesMedCC = false;
            bool includesLarCC = false;

            /* Markarth Milk */
            bool includesSmallMM = false;
            bool includesMedMM = false;
            bool includesLarMM = false;

            /* Sailor Soda */
            bool includesSmallSS = false;
            bool includesMedSS = false;
            bool includesLarSS = false;

            /* Warrior Water */
            bool includesSmallWW = false;
            bool includesMedWW = false;
            bool includesLarWW = false;

            int numberOfItemsInSizeEnum = Enum.GetValues(typeof(Size)).Length;

            int numberOfDrinksAtBleakwindBuffet = 5;
            int expectedNumberOfItemsInDrinksList = numberOfDrinksAtBleakwindBuffet * numberOfItemsInSizeEnum;

            IEnumerable<IOrderItem> d = Menu.Drinks();
            List<IOrderItem> drinks = (List<IOrderItem>)d;

            Assert.Equal(expectedNumberOfItemsInDrinksList, drinks.Count);

            for (int i = 0; i < expectedNumberOfItemsInDrinksList; i++)
            {
                if (drinks[i] is ArentinoAppleJuice)
                {
                    var AAJ = (ArentinoAppleJuice)drinks[i];
                    if (AAJ.Size == Size.Small) includesSmallAAJ = true;
                    else if (AAJ.Size == Size.Medium) includesMedAAJ = true;
                    else if (AAJ.Size == Size.Large) includesLarAAJ = true;
                    else throw new NotImplementedException();
                }

                else if (drinks[i] is CandlehearthCoffee)
                {
                    var CC = (CandlehearthCoffee)drinks[i];
                    if (CC.Size == Size.Small) includesSmallCC = true;
                    else if (CC.Size == Size.Medium) includesMedCC = true;
                    else if (CC.Size == Size.Large) includesLarCC = true;
                    else throw new NotImplementedException();
                }

                else if (drinks[i] is MarkarthMilk)
                {
                    var MM = (MarkarthMilk)drinks[i];
                    if (MM.Size == Size.Small) includesSmallMM = true;
                    else if (MM.Size == Size.Medium) includesMedMM = true;
                    else if (MM.Size == Size.Large) includesLarMM = true;
                    else throw new NotImplementedException();
                }

                else if (drinks[i] is SailorSoda)
                {
                    var SS = (SailorSoda)drinks[i];
                    if (SS.Size == Size.Small) includesSmallSS = true;
                    else if (SS.Size == Size.Medium) includesMedSS = true;
                    else if (SS.Size == Size.Large) includesLarSS = true;
                    else throw new NotImplementedException();
                }

                else if (drinks[i] is WarriorWater)
                {
                    var WW = (WarriorWater)drinks[i];
                    if (WW.Size == Size.Small) includesSmallWW = true;
                    else if (WW.Size == Size.Medium) includesMedWW = true;
                    else if (WW.Size == Size.Large) includesLarWW = true;
                    else throw new NotImplementedException();
                }

                else throw new NotImplementedException();
            }

            /* Aretino Apple Juice */
            Assert.True(includesSmallAAJ);
            Assert.True(includesMedAAJ);
            Assert.True(includesLarAAJ);

            /* Candlehearth Coffee */
            Assert.True(includesSmallCC);
            Assert.True(includesMedCC);
            Assert.True(includesLarCC);

            /* Markarth Milk */
            Assert.True(includesSmallMM);
            Assert.True(includesMedMM);
            Assert.True(includesLarMM);

            /* Sailor Soda */
            Assert.True(includesSmallSS);
            Assert.True(includesMedSS);
            Assert.True(includesLarSS);

            /* Warrior Water */
            Assert.True(includesSmallWW);
            Assert.True(includesMedWW);
            Assert.True(includesLarWW);
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
        /// Test that the full menu is initialized, taken from TA solution
        /// </summary>
        [Fact]
        public void FullMenuInitialized()
        {
            int numberOfItemsInSizeEnum = Enum.GetValues(typeof(Size)).Length;

            int expectedNumberOfEntrees = 7;
            int expectedNumberOfSides = 4;
            int expectedNumberOfDrinks = 5;

            int expectedNumberOfMenuItems = (expectedNumberOfSides * numberOfItemsInSizeEnum) + (expectedNumberOfDrinks * numberOfItemsInSizeEnum) + expectedNumberOfEntrees;

            IEnumerable<IOrderItem> FM = Menu.FullMenu();
            List<IOrderItem> fullMenu = (List<IOrderItem>)FM;

            Assert.Equal(fullMenu.Count, expectedNumberOfMenuItems);


        }

        /// <summary>
        /// check different cases of search term to get expected return expected 3 values (small medium or large) of a drink or side
        /// </summary>
        /// <param name="searchTerms">upper or lower case search term</param>
        [Theory]
        [InlineData("Fried")]
        [InlineData("fried")]
        [InlineData("water")]
        [InlineData("WATER")]
        public void SearchFunctionWorksWithUpperAndLowerValues(string searchTerms)
        {
            IEnumerable<IOrderItem> s = Menu.Search(searchTerms);
            List<IOrderItem> search = (List<IOrderItem>)s;
            int expectedNumberofResults = 3; //1 for each size

            Assert.Equal(search.Count, expectedNumberofResults);
        }

        /// <summary>
        /// check that null search terms returns the whole menu
        /// </summary>
        [Fact]
        public void SearchWorksWithNull()
        {
            IEnumerable<IOrderItem> s = Menu.Search(null);
            List<IOrderItem> search = (List<IOrderItem>)s;

            IEnumerable<IOrderItem>FM = Menu.FullMenu();
            List<IOrderItem> fullMenu = (List<IOrderItem>)FM;

            Assert.Equal(search.Count, fullMenu.Count);
        }

        /// <summary>
        /// test that the entree filter returns all entrees
        /// </summary>
        [Fact]
        public void EntreeCategoryFiterWorks()
        {
            string[] selectedCategory = new string[1];
            selectedCategory[0] = "Entree";
            
            IEnumerable<IOrderItem> c = Menu.FilterByCategory(Menu.FullMenu(), selectedCategory);
            List<IOrderItem> category = (List<IOrderItem>)c;

            Assert.Equal(Menu.Entrees().Count(), category.Count);
        }

        /// <summary>
        /// test that the drink filter returns all entrees
        /// </summary>
        [Fact]
        public void DrinkCategoryFiterWorks()
        {
            string[] selectedCategory = new string[1];
            selectedCategory[0] = "Drink";

            IEnumerable<IOrderItem> c = Menu.FilterByCategory(Menu.FullMenu(), selectedCategory);
            List<IOrderItem> category = (List<IOrderItem>)c;

            Assert.Equal(Menu.Drinks().Count(), category.Count);
        }

        /// <summary>
        /// test that the entree filter returns all entrees
        /// </summary>
        [Fact]
        public void SideCategoryFiterWorks()
        {
            string[] selectedCategory = new string[1];
            selectedCategory[0] = "Side";

            IEnumerable<IOrderItem> c = Menu.FilterByCategory(Menu.FullMenu(), selectedCategory);
            List<IOrderItem> category = (List<IOrderItem>)c;

            Assert.Equal(Menu.Sides().Count(), category.Count);
        }


        /// <summary>
        /// check that null values of price min and max returns whole menu
        /// </summary>
        [Fact]
        public void PriceFilterWorksWithNullVlaues()
        {
            IEnumerable<IOrderItem> p = Menu.FilterByPrice(Menu.FullMenu(), null, null);
            List<IOrderItem> price = (List<IOrderItem>)p;

            Assert.Equal(price.Count, Menu.FullMenu().Count());
        }


        /// <summary>
        /// check that max values of price min and max returns whole menu
        /// </summary>
        [Fact]
        public void PriceFilterWorksWithMaxVlaues()
        {
            IEnumerable<IOrderItem> p = Menu.FilterByPrice(Menu.FullMenu(), 0, 20);
            List<IOrderItem> price = (List<IOrderItem>)p;

            Assert.Equal(price.Count, Menu.FullMenu().Count());
        }


        /// <summary>
        /// check that max values of calorie min and max returns whole menu
        /// </summary>
        [Fact]
        public void CaloriesFilterWorksWithMaxRange()
        {
            IEnumerable<IOrderItem> c = Menu.FilterByCalories(Menu.FullMenu(), 0, 1000);
            List<IOrderItem> calories = (List<IOrderItem>)c;

            Assert.Equal(calories.Count, Menu.FullMenu().Count());
        }

        /// <summary>
        /// check that null values of calorie min and max returns whole menu
        /// </summary>
        [Fact]
        public void CaloriesFilterWorksWithNullVlaues()
        {
            IEnumerable<IOrderItem> c = Menu.FilterByCalories(Menu.FullMenu(), null, null);
            List<IOrderItem> calories = (List<IOrderItem>)c;

            Assert.Equal(calories.Count, Menu.FullMenu().Count());
        }

    }
}