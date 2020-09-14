/*
 * Author: Zachery Brunner
 * Class: CandlehearthCoffeeTests.cs
 * Purpose: Test the CandlehearthCoffee.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.Runtime.InteropServices.ComTypes;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    /// <summary>
    /// testing class for Candle Hearth Coffee 
    /// </summary>
    public class CandlehearthCoffeeTests
    {
        /// <summary>
        /// tests that this class inherits from the IOrderItem interface
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            Assert.IsAssignableFrom<IOrderItem>(chc);
        }

        /// <summary>
        /// ensures this class inherits from the base drink class
        /// </summary>
        [Fact]
        public void ShouldBeADrink()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            Assert.IsAssignableFrom<Drink>(chc);
        }

        /// <summary>
        /// Tests the default value for Ice is zero
        /// </summary>
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            Assert.False(chc.Ice);
        }

        /// <summary>
        /// Tests default decaf is false
        /// </summary>
        [Fact]
        public void ShouldNotBeDecafByDefault()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            Assert.False(chc.Decaf);
        }

        /// <summary>
        /// Tests default RoomForCream is false
        /// </summary>
        [Fact]
        public void ShouldNotHaveRoomForCreamByDefault()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            Assert.False(chc.RoomForCream);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            Assert.Equal(Size.Small, chc.Size);
        }

        /// <summary>
        /// Tests ice variable can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            chc.Ice = true;
            Assert.True(chc.Ice);
            chc.Ice = false;
            Assert.False(chc.Ice);
        }

        /// <summary>
        /// Tests if decaf can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetDecaf()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            chc.Decaf = true;
            Assert.True(chc.Decaf);
            chc.Decaf = false;
            Assert.False(chc.Decaf);
        }

        /// <summary>
        /// Tests RoomForCream variable can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetRoomForCream()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            chc.RoomForCream = true;
            Assert.True(chc.RoomForCream);
            chc.RoomForCream = false;
            Assert.False(chc.RoomForCream);
        }

        /// <summary>
        /// Tests size setting of apple juice
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            chc.Size = Size.Large;
            Assert.Equal(Size.Large, chc.Size);
            chc.Size = Size.Medium;
            Assert.Equal(Size.Medium, chc.Size);
            chc.Size = Size.Small;
            Assert.Equal(Size.Small, chc.Size);
        }

        /// <summary>
        /// Tests all the size possibilities for the price 
        /// </summary>
        /// <param name="size">Size of drink</param>
        /// <param name="price">Price based on size</param>
        [Theory]
        [InlineData(Size.Small, 0.75)]
        [InlineData(Size.Medium, 1.25)]
        [InlineData(Size.Large, 1.75)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            chc.Size = size;
            Assert.Equal(price, chc.Price);
        }

        /// <summary>
        /// Tests the proper calorie count goes with the right size
        /// </summary>
        /// <param name="size">Size of drink</param>
        /// <param name="cal">Calorie count of the drink</param>
        [Theory]
        [InlineData(Size.Small, 7)]
        [InlineData(Size.Medium, 10)]
        [InlineData(Size.Large, 20)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            chc.Size = size;
            Assert.Equal(cal, chc.Calories);
        }

        /// <summary>
        /// Tests the special instructions based is correct no matter the values given
        /// </summary>
        /// <param name="includeIce">Value of ice</param>
        /// <param name="includeCream">Value of includeCream</param>
        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeCream)
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            chc.Ice = includeIce;
            chc.RoomForCream = includeCream;
            if (includeIce)
            {
                Assert.Contains("Add ice", chc.SpecialInstructions);
            }
            else if (!includeIce)
            {
                Assert.DoesNotContain("Add ice", chc.SpecialInstructions);
            }
            if(includeCream)
            {
                Assert.Contains("Add cream", chc.SpecialInstructions);
            }
            else if (!includeCream)
            {
                Assert.DoesNotContain("Add cream", chc.SpecialInstructions);
            }
            if(!includeCream && !includeIce)
            {
                Assert.Empty(chc.SpecialInstructions);
            }
        }

        /// <summary>
        /// Tests ToString() method of drink based on size
        /// </summary>
        /// <param name="size">Size of drink</param>
        /// <param name="name">Correct output of TosString() based on given size</param>
        [Theory]
        [InlineData(true, Size.Small, "Small Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Medium, "Medium Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Large, "Large Decaf Candlehearth Coffee")]
        [InlineData(false, Size.Small, "Small Candlehearth Coffee")]
        [InlineData(false, Size.Medium, "Medium Candlehearth Coffee")]
        [InlineData(false, Size.Large, "Large Candlehearth Coffee")]
        public void ShouldReturnCorrectToStringBasedOnSize(bool decaf, Size size, string name)
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            chc.Decaf = decaf;
            chc.Size = size;
            Assert.Equal(name, chc.ToString());

        }
    }
}
