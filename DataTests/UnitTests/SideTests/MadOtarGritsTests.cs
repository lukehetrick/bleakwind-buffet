/*
 * Author: Zachery Brunner
 * Class: MadOtarGritsTests.cs
 * Purpose: Test the MadOtarGrits.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    /// <summary>
    /// Testing class for Mad Otar grits
    /// </summary>
    public class MadOtarGritsTests
    {
        /// <summary>
        /// ensures this class inherits from the IOrderItem interface
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            MadOtarGrits mog = new MadOtarGrits();
            Assert.IsAssignableFrom<IOrderItem>(mog);
        }

        /// <summary>
        /// ensures this class inherits from the base Side class
        /// </summary>
        [Fact]
        public void ShouldBeASide()
        {
            MadOtarGrits mog = new MadOtarGrits();
            Assert.IsAssignableFrom<Side>(mog);
        }
        /// <summary>
        /// Tests that default value of size is small
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            MadOtarGrits mog = new MadOtarGrits();
            Assert.Equal(Size.Small, mog.Size);
        }

        /// <summary>
        /// Tests size setting of side
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MadOtarGrits mog = new MadOtarGrits();
            mog.Size = Size.Large;
            Assert.Equal(Size.Large, mog.Size);
            mog.Size = Size.Medium;
            Assert.Equal(Size.Medium, mog.Size);
            mog.Size = Size.Small;
            Assert.Equal(Size.Small, mog.Size);
        }

        /// <summary>
        /// no speical instructions
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            MadOtarGrits mog = new MadOtarGrits();
            Assert.Empty(mog.SpecialInstructions);
        }

        /// <summary>
        /// Tests all the size possibilities for the price 
        /// </summary>
        /// <param name="size">Size of side</param>
        /// <param name="price">Price based on size</param>
        [Theory]
        [InlineData(Size.Small, 1.22)]
        [InlineData(Size.Medium, 1.58)]
        [InlineData(Size.Large, 1.93)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            MadOtarGrits mog = new MadOtarGrits();
            mog.Size = size;
            Assert.Equal(price, mog.Price);
        }

        /// <summary>
        /// Tests the proper calorie count goes with the right size
        /// </summary>
        /// <param name="size">Size of drink</param>
        /// <param name="calories">Calorie count of the drink</param>
        [Theory]
        [InlineData(Size.Small, 105)]
        [InlineData(Size.Medium, 142)]
        [InlineData(Size.Large, 179)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            MadOtarGrits mog = new MadOtarGrits();
            mog.Size = size;
            Assert.Equal(calories, mog.Calories);
        }

        /// <summary>
        /// Tests ToString() method of side based on size
        /// </summary>
        /// <param name="size">Size of side</param>
        /// <param name="name">Correct output of TosString() based on given size</param>
        [Theory]
        [InlineData(Size.Small, "Small Mad Otar Grits")]
        [InlineData(Size.Medium, "Medium Mad Otar Grits")]
        [InlineData(Size.Large, "Large Mad Otar Grits")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MadOtarGrits mog = new MadOtarGrits();
            mog.Size = size;
            Assert.Equal(name, mog.ToString());
        }

        /// <summary>
        /// tests that Size property is notified when changed
        /// </summary>
        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            MadOtarGrits mog = new MadOtarGrits();

            Assert.PropertyChanged(mog, "Size", () =>
            {
                mog.Size = Size.Large;
            });

            Assert.PropertyChanged(mog, "Size", () =>
            {
                mog.Size = Size.Medium;
            });

            Assert.PropertyChanged(mog, "Size", () =>
            {
                mog.Size = Size.Large;
            });
        }

        /// <summary>
        /// tests that Price property is notified when Size is changed
        /// </summary>
        [Fact]
        public void ChangingSizeNotifiesPriceProperty()
        {
            MadOtarGrits mog = new MadOtarGrits();

            Assert.PropertyChanged(mog, "Price", () =>
            {
                mog.Size = Size.Large;
            });

            Assert.PropertyChanged(mog, "Price", () =>
            {
                mog.Size = Size.Medium;
            });

            Assert.PropertyChanged(mog, "Price", () =>
            {
                mog.Size = Size.Large;
            });
        }

        /// <summary>
        /// tests that Calories property is notified when Size is changed
        /// </summary>
        [Fact]
        public void ChangingSizeNotifiesCaloriesProperty()
        {
            MadOtarGrits mog = new MadOtarGrits();

            Assert.PropertyChanged(mog, "Calories", () =>
            {
                mog.Size = Size.Large;
            });

            Assert.PropertyChanged(mog, "Calories", () =>
            {
                mog.Size = Size.Medium;
            });

            Assert.PropertyChanged(mog, "Calories", () =>
            {
                mog.Size = Size.Large;
            });
        }


        /// <summary>
        /// tests that this class inherits from the INotifyPropertyChanged interface
        /// </summary>
        [Fact]
        public void ShouldBeAnINotifyPropertyChanged()
        {
            MadOtarGrits mog = new MadOtarGrits();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(mog);
        }
    }
}