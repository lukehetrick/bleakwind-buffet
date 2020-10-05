/*
 * Author: Zachery Brunner
 * Class: DragonbornWaffleFriesTests.cs
 * Purpose: Test the DragonbornWaffleFries.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    /// <summary>
    /// Testing class for dragonborn waffle fries
    /// </summary>
    public class DragonbornWaffleFriesTests
    {
        /// <summary>
        /// ensures this class inherits from the IOrderItem interface
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderInterface()
        {
            DragonbornWaffleFries wf = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<IOrderItem>(wf);
        }

        /// <summary>
        /// ensures this class inherits from the base Side class
        /// </summary>
        [Fact]
        public void ShouldBeASide()
        {
            DragonbornWaffleFries wf = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<Side>(wf);
        }

        /// <summary>
        /// Tests that default value of size is small
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            DragonbornWaffleFries wf = new DragonbornWaffleFries();
            Assert.Equal(Size.Small, wf.Size);
        }

        /// <summary>
        /// Tests size setting of side
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            DragonbornWaffleFries wf = new DragonbornWaffleFries();
            wf.Size = Size.Large;
            Assert.Equal(Size.Large, wf.Size);
            wf.Size = Size.Medium;
            Assert.Equal(Size.Medium, wf.Size);
            wf.Size = Size.Small;
            Assert.Equal(Size.Small, wf.Size);
        }

        /// <summary>
        /// no speical instructions
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            DragonbornWaffleFries wf = new DragonbornWaffleFries();
            Assert.Empty(wf.SpecialInstructions);
        }

        /// <summary>
        /// Tests all the size possibilities for the price 
        /// </summary>
        /// <param name="size">Size of side</param>
        /// <param name="price">Price based on size</param>
        [Theory]
        [InlineData(Size.Small, 0.42)]
        [InlineData(Size.Medium, 0.76)]
        [InlineData(Size.Large, 0.96)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            DragonbornWaffleFries wf = new DragonbornWaffleFries();
            wf.Size = size;
            Assert.Equal(price, wf.Price);
        }

        /// <summary>
        /// Tests the proper calorie count goes with the right size
        /// </summary>
        /// <param name="size">Size of drink</param>
        /// <param name="calories">Calorie count of the drink</param>
        [Theory]
        [InlineData(Size.Small, 77)]
        [InlineData(Size.Medium, 89)]
        [InlineData(Size.Large, 100)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            DragonbornWaffleFries wf = new DragonbornWaffleFries();
            wf.Size = size;
            Assert.Equal(calories, wf.Calories);
        }

        /// <summary>
        /// Tests ToString() method of side based on size
        /// </summary>
        /// <param name="size">Size of side</param>
        /// <param name="name">Correct output of TosString() based on given size</param>
        [Theory]
        [InlineData(Size.Small, "Small Dragonborn Waffle Fries")]
        [InlineData(Size.Medium, "Medium Dragonborn Waffle Fries")]
        [InlineData(Size.Large, "Large Dragonborn Waffle Fries")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            DragonbornWaffleFries wf = new DragonbornWaffleFries();
            wf.Size = size;
            Assert.Equal(name, wf.ToString());
        }

        /// <summary>
        /// tests that Size property is notified when changed
        /// </summary>
        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            DragonbornWaffleFries wf = new DragonbornWaffleFries();

            Assert.PropertyChanged(wf, "Size", () =>
            {
                wf.Size = Size.Large;
            });

            Assert.PropertyChanged(wf, "Size", () =>
            {
                wf.Size = Size.Medium;
            });

            Assert.PropertyChanged(wf, "Size", () =>
            {
                wf.Size = Size.Large;
            });
        }

        /// <summary>
        /// tests that Price property is notified when Size is changed
        /// </summary>
        [Fact]
        public void ChangingSizeNotifiesPriceProperty()
        {
            DragonbornWaffleFries wf = new DragonbornWaffleFries();

            Assert.PropertyChanged(wf, "Price", () =>
            {
                wf.Size = Size.Large;
            });

            Assert.PropertyChanged(wf, "Price", () =>
            {
                wf.Size = Size.Medium;
            });

            Assert.PropertyChanged(wf, "Price", () =>
            {
                wf.Size = Size.Large;
            });
        }

        /// <summary>
        /// tests that Calories property is notified when Size is changed
        /// </summary>
        [Fact]
        public void ChangingSizeNotifiesCaloriesProperty()
        {
            DragonbornWaffleFries wf = new DragonbornWaffleFries();

            Assert.PropertyChanged(wf, "Calories", () =>
            {
                wf.Size = Size.Large;
            });

            Assert.PropertyChanged(wf, "Calories", () =>
            {
                wf.Size = Size.Medium;
            });

            Assert.PropertyChanged(wf, "Calories", () =>
            {
                wf.Size = Size.Large;
            });
        }


        /// <summary>
        /// tests that this class inherits from the INotifyPropertyChanged interface
        /// </summary>
        [Fact]
        public void ShouldBeAnINotifyPropertyChanged()
        {
            DragonbornWaffleFries wf = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(wf);
        }
    }
}