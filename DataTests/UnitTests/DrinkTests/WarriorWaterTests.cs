/*
 * Author: Luke Hetrick
 * Class: WarriorWaterTests.cs
 * Purpose: Test the WarriorWater.cs class in the Data library
 */
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Drinks;
using Xunit;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    /// <summary>
    /// Testing class for Warrior water
    /// </summary>
    public class WarriorWaterTests
    {
        /// <summary>
        /// ensures this class inherits from the IOrderItem interface
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            WarriorWater ww = new WarriorWater();
            Assert.IsAssignableFrom<IOrderItem>(ww);
        }

        /// <summary>
        /// ensures this class inherits from the base drink class
        /// </summary>
        [Fact]
        public void ShouldBeADrink()
        {
            WarriorWater ww = new WarriorWater();
            Assert.IsAssignableFrom<Drink>(ww);
        }

        /// <summary>
        /// Tests the default value for Ice is false
        /// </summary>
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.True(ww.Ice);
        }

        /// <summary>
        /// Tests the default value for Ice is false
        /// </summary>
        [Fact]
        public void ShouldNotIncludeLemonByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.False(ww.Lemon);
        }

        /// <summary>
        /// Tests that default value of size is small
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.Equal(Size.Small, ww.Size);
        }

        /// <summary>
        /// Tests ice variable can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            WarriorWater ww = new WarriorWater();
            ww.Ice = true;
            Assert.True(ww.Ice);
            ww.Ice = false;
            Assert.False(ww.Ice);
        }

        /// <summary>
        /// Tests Lemon variable can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetLemon()
        {
            WarriorWater ww = new WarriorWater();
            ww.Lemon = true;
            Assert.True(ww.Lemon);
            ww.Lemon = false;
            Assert.False(ww.Lemon);
        }

        /// <summary>
        /// Tests size setting of water
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = Size.Large;
            Assert.Equal(Size.Large, ww.Size);
            ww.Size = Size.Medium;
            Assert.Equal(Size.Medium, ww.Size);
            ww.Size = Size.Small;
            Assert.Equal(Size.Small, ww.Size);
        }

        /// <summary>
        /// Tests the special instructions based is correct no matter the values given
        /// </summary>
        /// <param name="includeIce">Value of ice</param>
        /// <param name="includelemon">value of lemon</param>
        [Theory]
        [InlineData(true, false)]
        [InlineData(false, true)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includelemon)
        {
            WarriorWater ww = new WarriorWater();
            ww.Ice = includeIce;
            ww.Lemon = includelemon;
            if (!includeIce)
            {
                Assert.Contains("Hold ice", ww.SpecialInstructions);
                Assert.Contains("Add lemon", ww.SpecialInstructions);

            }
            else
            {
                Assert.Empty(ww.SpecialInstructions);
            }
        }

        /// <summary>
        /// Tests all the size possibilities for the price 
        /// </summary>
        /// <param name="size">Size of drink</param>
        /// <param name="price">Price based on size</param>
        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = size;
            Assert.Equal(price, ww.Price);
        }

        /// <summary>
        /// Tests the proper calorie count goes with the right size
        /// </summary>
        /// <param name="size">Size of drink</param>
        /// <param name="cal">Calorie count of the drink</param>
        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = size;
            Assert.Equal(cal, ww.Calories);
        }


        /// <summary>
        /// Tests ToString() method of drink based on size
        /// </summary>
        /// <param name="size">Size of drink</param>
        /// <param name="name">Correct output of TosString() based on given size</param>
        [Theory]
        [InlineData(Size.Small, "Small Warrior Water")]
        [InlineData(Size.Medium, "Medium Warrior Water")]
        [InlineData(Size.Large, "Large Warrior Water")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = size;
            Assert.Equal(name, ww.ToString());
        }
    }
}
