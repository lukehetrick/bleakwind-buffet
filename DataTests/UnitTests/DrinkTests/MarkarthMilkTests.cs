/*
 * Author: Zachery Brunner
 * Class: MarkarthMilkTests.cs
 * Purpose: Test the MarkarthMilk.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    /// <summary>
    /// testing class for Markarth Milk
    /// </summary>
    public class MarkarthMilkTests
    {
        /// <summary>
        /// ensures this class inherits from the IOrderItem interface
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.IsAssignableFrom<IOrderItem>(mm);
        }

        /// <summary>
        /// ensures this class inherits from the base drink class
        /// </summary>
        [Fact]
        public void ShouldBeADrink()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.IsAssignableFrom<Drink>(mm);
        }

        /// <summary>
        /// Tests the default value for Ice is false
        /// </summary>
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.False(mm.Ice);
        }

        /// <summary>
        /// Tests that default value of size is small
        /// </summary>
        [Fact]
        public void ShouldBySmallByDefault()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.Equal(Size.Small, mm.Size);
        }

        /// <summary>
        /// Tests ice variable can be set
        /// </summary>
        [Fact]
        public void ShouldByAbleToSetIce()
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Ice = true;
            Assert.True(mm.Ice);
            mm.Ice = false;            
            Assert.False(mm.Ice);
        }

        /// <summary>
        /// Tests size setting of apple juice
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Size = Size.Large;
            Assert.Equal(Size.Large, mm.Size);
            mm.Size = Size.Medium;
            Assert.Equal(Size.Medium, mm.Size);
            mm.Size = Size.Small;
            Assert.Equal(Size.Small, mm.Size);
        }

        /// <summary>
        /// Tests all the size possibilities for the price 
        /// </summary>
        /// <param name="size">Size of drink</param>
        /// <param name="price">Price based on size</param>
        [Theory]
        [InlineData(Size.Small, 1.05)]
        [InlineData(Size.Medium, 1.11)]
        [InlineData(Size.Large, 1.22)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Size = size;
            Assert.Equal(price, mm.Price);
        }

        /// <summary>
        /// Tests the proper calorie count goes with the right size
        /// </summary>
        /// <param name="size">Size of drink</param>
        /// <param name="cal">Calorie count of the drink</param>
        [Theory]
        [InlineData(Size.Small, 56)]
        [InlineData(Size.Medium, 72)]
        [InlineData(Size.Large, 93)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Size = size;
            Assert.Equal(cal, mm.Calories);
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
            MarkarthMilk mm = new MarkarthMilk();
            mm.Ice = includeIce;
            if (includeIce)
            {
                Assert.Contains("Add ice", mm.SpecialInstructions);
            }
            else
            {
                Assert.Empty(mm.SpecialInstructions);
            }
        }

        /// <summary>
        /// tests that it returns the correct string fo ToString method
        /// </summary>
        /// <param name="size">size of dink</param>
        /// <param name="name">correct toString return</param>
        [Theory]
        [InlineData(Size.Small, "Small Markarth Milk")]
        [InlineData(Size.Medium, "Medium Markarth Milk")]
        [InlineData(Size.Large, "Large Markarth Milk")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Size = size;
            Assert.Equal(name, mm.ToString());
        }

        /// <summary>
        /// tests that Ice property is notified when changed
        /// </summary>
        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            MarkarthMilk mm = new MarkarthMilk();

            Assert.PropertyChanged(mm, "Ice", () =>
            {
                mm.Ice = true;
            });

            Assert.PropertyChanged(mm, "Ice", () =>
            {
                mm.Ice = false;
            });
        }

        /// <summary>
        /// tests that SpecialInstructions property is notified when Ice is changed
        /// </summary>
        [Fact]
        public void ChangingIceNotifiesSpecialInstructions()
        {
            MarkarthMilk mm = new MarkarthMilk();

            Assert.PropertyChanged(mm, "SpecialInstructions", () =>
            {
                mm.Ice = true;
            });

            Assert.PropertyChanged(mm, "SpecialInstructions", () =>
            {
                mm.Ice = false;
            });

        }

        /// <summary>
        /// tests that Size property is notified when changed
        /// </summary>
        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            MarkarthMilk mm = new MarkarthMilk();

            Assert.PropertyChanged(mm, "Size", () =>
            {
                mm.Size = Size.Large;
            });

            Assert.PropertyChanged(mm, "Size", () =>
            {
                mm.Size = Size.Medium;
            });

            Assert.PropertyChanged(mm, "Size", () =>
            {
                mm.Size = Size.Large;
            });
        }

        /// <summary>
        /// tests that Price property is notified when Size is changed
        /// </summary>
        [Fact]
        public void ChangingSizeNotifiesPriceProperty()
        {
            MarkarthMilk mm = new MarkarthMilk();

            Assert.PropertyChanged(mm, "Price", () =>
            {
                mm.Size = Size.Large;
            });

            Assert.PropertyChanged(mm, "Price", () =>
            {
                mm.Size = Size.Medium;
            });

            Assert.PropertyChanged(mm, "Price", () =>
            {
                mm.Size = Size.Large;
            });
        }

        /// <summary>
        /// tests that Calories property is notified when Size is changed
        /// </summary>
        [Fact]
        public void ChangingSizeNotifiesCaloriesProperty()
        {
            MarkarthMilk mm = new MarkarthMilk();

            Assert.PropertyChanged(mm, "Calories", () =>
            {
                mm.Size = Size.Large;
            });

            Assert.PropertyChanged(mm, "Calories", () =>
            {
                mm.Size = Size.Medium;
            });

            Assert.PropertyChanged(mm, "Calories", () =>
            {
                mm.Size = Size.Large;
            });
        }


        /// <summary>
        /// tests that this class inherits from the INotifyPropertyChanged interface
        /// </summary>
        [Fact]
        public void ShouldBeAnINotifyPropertyChanged()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(mm);
        }
    }
}