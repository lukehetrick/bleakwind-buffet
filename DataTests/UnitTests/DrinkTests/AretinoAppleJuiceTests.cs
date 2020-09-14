/*
 * Author: Zachery Brunner
 * Class: AretinoAppleJuiceTests.cs
 * Purpose: Test the AretinoAppleJuice.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    /// <summary>
    /// testing class for Arentino Apple juice
    /// </summary>
    public class AretinoAppleJuiceTests
    {
        /// <summary>
        /// tests that this class inherits from the IOrderItem interface
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            ArentinoAppleJuice aj = new ArentinoAppleJuice();
            Assert.IsAssignableFrom<IOrderItem>(aj);
        }

        /// <summary>
        /// ensures this class inherits from the base drink class
        /// </summary>
        [Fact]
        public void ShouldBeADrink()
        {
            ArentinoAppleJuice aj = new ArentinoAppleJuice();
            Assert.IsAssignableFrom<Drink>(aj);
        }

        /// <summary>
        /// Tests the default value for Ice is false
        /// </summary>
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            ArentinoAppleJuice aj = new ArentinoAppleJuice();
            Assert.False(aj.Ice);
        }

        /// <summary>
        /// Tests that default value of size is small
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            ArentinoAppleJuice aj = new ArentinoAppleJuice();
            Assert.Equal(Size.Small, aj.Size);
        }

        /// <summary>
        /// Tests ice variable can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            ArentinoAppleJuice aj = new ArentinoAppleJuice();
            aj.Ice = true;
            Assert.True(aj.Ice);
            aj.Ice = false;
            Assert.False(aj.Ice);
        }

        /// <summary>
        /// Tests size setting of apple juice
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            ArentinoAppleJuice aj = new ArentinoAppleJuice();
            aj.Size = Size.Large;
            Assert.Equal(Size.Large, aj.Size);
            aj.Size = Size.Medium;
            Assert.Equal(Size.Medium, aj.Size);
            aj.Size = Size.Small;
            Assert.Equal(Size.Small, aj.Size);
        }

        /// <summary>
        /// Tests all the size possibilities for the price 
        /// </summary>
        /// <param name="size">Size of drink</param>
        /// <param name="price">Price based on size</param>
        [Theory]
        [InlineData(Size.Small, 0.62)]
        [InlineData(Size.Medium, 0.87)]
        [InlineData(Size.Large, 1.01)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            ArentinoAppleJuice aj = new ArentinoAppleJuice();
            aj.Size = size;
            Assert.Equal(price, aj.Price);
        }

        /// <summary>
        /// Tests the proper calorie count goes with the right size
        /// </summary>
        /// <param name="size">Size of drink</param>
        /// <param name="cal">Calorie count of the drink</param>
        [Theory]
        [InlineData(Size.Small, 44)]
        [InlineData(Size.Medium, 88)]
        [InlineData(Size.Large, 132)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            ArentinoAppleJuice aj = new ArentinoAppleJuice();
            aj.Size = size;                        
            Assert.Equal(cal, aj.Calories);
        }

        /// <summary>
        /// Tests the special instructions based is correct no matter the values given
        /// </summary>
        /// <param name="includeIce">Value of ice</param>
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            ArentinoAppleJuice aj = new ArentinoAppleJuice();
            aj.Ice = includeIce;
            if (includeIce)
            {
                Assert.Contains("Add ice", aj.SpecialInstructions); 
            }
            else
            {
                Assert.Empty(aj.SpecialInstructions);
            }
        }

        /// <summary>
        /// Tests ToString() method of drink based on size
        /// </summary>
        /// <param name="size">Size of drink</param>
        /// <param name="name">Correct output of TosString() based on given size</param>
        [Theory]
        [InlineData(Size.Small, "Small Aretino Apple Juice")]
        [InlineData(Size.Medium, "Medium Aretino Apple Juice")]
        [InlineData(Size.Large, "Large Aretino Apple Juice")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            ArentinoAppleJuice aj = new ArentinoAppleJuice();
            aj.Size = size;
            Assert.Equal(name, aj.ToString());
        }
    }
}