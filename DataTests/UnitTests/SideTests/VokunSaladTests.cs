/*
 * Author: Zachery Brunner
 * Class: VokunSaladTests.cs
 * Purpose: Test the VokunSalad.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    /// <summary>
    /// Testing class for Vokun salad
    /// </summary>
    public class VokunSaladTests
    {
        /// <summary>
        /// ensures this class inherits from the IOrderItem interface
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            VokunSalad vs = new VokunSalad();
            Assert.IsAssignableFrom<IOrderItem>(vs);
        }

        /// <summary>
        /// ensures this class inherits from the base Side class
        /// </summary>
        [Fact]
        public void ShouldBeASide()
        {
            VokunSalad vs = new VokunSalad();
            Assert.IsAssignableFrom<Side>(vs);
        }
        /// <summary>
        /// Tests that default value of size is small
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            VokunSalad vs = new VokunSalad();
            Assert.Equal(Size.Small, vs.Size);
        }

        /// <summary>
        /// Tests size setting of side
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            VokunSalad vs = new VokunSalad();
            vs.Size = Size.Large;
            Assert.Equal(Size.Large, vs.Size);
            vs.Size = Size.Medium;
            Assert.Equal(Size.Medium, vs.Size);
            vs.Size = Size.Small;
            Assert.Equal(Size.Small, vs.Size);
        }

        /// <summary>
        /// no speical instructions
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            VokunSalad vs = new VokunSalad();
            Assert.Empty(vs.SpecialInstructions);
        }

        /// <summary>
        /// Tests all the size possibilities for the price 
        /// </summary>
        /// <param name="size">Size of side</param>
        /// <param name="price">Price based on size</param>
        [Theory]
        [InlineData(Size.Small, 0.93)]
        [InlineData(Size.Medium, 1.28)]
        [InlineData(Size.Large, 1.82)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            VokunSalad vs = new VokunSalad();
            vs.Size = size;
            Assert.Equal(price, vs.Price);
        }

        /// <summary>
        /// Tests the proper calorie count goes with the right size
        /// </summary>
        /// <param name="size">Size of drink</param>
        /// <param name="calories">Calorie count of the drink</param>
        [Theory]
        [InlineData(Size.Small, 41)]
        [InlineData(Size.Medium, 52)]
        [InlineData(Size.Large, 73)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            VokunSalad vs = new VokunSalad();
            vs.Size = size;
            Assert.Equal(calories, vs.Calories);
        }

        /// <summary>
        /// Tests ToString() method of side based on size
        /// </summary>
        /// <param name="size">Size of side</param>
        /// <param name="name">Correct output of TosString() based on given size</param>
        [Theory]
        [InlineData(Size.Small, "Small Vokun Salad")]
        [InlineData(Size.Medium, "Medium Vokun Salad")]
        [InlineData(Size.Large, "Large Vokun Salad")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            VokunSalad vs = new VokunSalad();
            vs.Size = size;
            Assert.Equal(name, vs.ToString());
        }

        /// <summary>
        /// tests that Size property is notified when changed
        /// </summary>
        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            VokunSalad vs = new VokunSalad();

            Assert.PropertyChanged(vs, "Size", () =>
            {
                vs.Size = Size.Large;
            });

            Assert.PropertyChanged(vs, "Size", () =>
            {
                vs.Size = Size.Medium;
            });

            Assert.PropertyChanged(vs, "Size", () =>
            {
                vs.Size = Size.Large;
            });
        }

        /// <summary>
        /// tests that Price property is notified when Size is changed
        /// </summary>
        [Fact]
        public void ChangingSizeNotifiesPriceProperty()
        {
            VokunSalad vs = new VokunSalad();

            Assert.PropertyChanged(vs, "Price", () =>
            {
                vs.Size = Size.Large;
            });

            Assert.PropertyChanged(vs, "Price", () =>
            {
                vs.Size = Size.Medium;
            });

            Assert.PropertyChanged(vs, "Price", () =>
            {
                vs.Size = Size.Large;
            });
        }

        /// <summary>
        /// tests that Calories property is notified when Size is changed
        /// </summary>
        [Fact]
        public void ChangingSizeNotifiesCaloriesProperty()
        {
            VokunSalad vs = new VokunSalad();

            Assert.PropertyChanged(vs, "Calories", () =>
            {
                vs.Size = Size.Large;
            });

            Assert.PropertyChanged(vs, "Calories", () =>
            {
                vs.Size = Size.Medium;
            });

            Assert.PropertyChanged(vs, "Calories", () =>
            {
                vs.Size = Size.Large;
            });
        }


        /// <summary>
        /// tests that this class inherits from the INotifyPropertyChanged interface
        /// </summary>
        [Fact]
        public void ShouldBeAnINotifyPropertyChanged()
        {
            VokunSalad vs = new VokunSalad();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(vs);
        }
    }
}