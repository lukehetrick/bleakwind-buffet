/*
 * Author: Zachery Brunner
 * Class: SailorSodaTests.cs
 * Purpose: Test the SailorSoda.cs class in the Data library
 */
using System;

using Xunit;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    /// <summary>
    /// class for testing the Sailor soda clas
    /// </summary>
    public class SailorSodaTests
    {
        /// <summary>
        /// ensures this class inherits from the IOrderItem interface
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            SailorSoda ss = new SailorSoda();
            Assert.IsAssignableFrom<IOrderItem>(ss);
        }

        /// <summary>
        /// ensures this class inherits from the base drink class
        /// </summary>
        [Fact]
        public void ShouldBeADrink()
        {
            SailorSoda ss = new SailorSoda();
            Assert.IsAssignableFrom<Drink>(ss);
        }

        /// <summary>
        /// Tests the default value for Ice is true
        /// </summary>
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            SailorSoda ss = new SailorSoda();
            Assert.True(ss.Ice);
        }

        /// <summary>
        /// Tests that default value of size is small
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            SailorSoda ss = new SailorSoda();
            Assert.Equal(Size.Small, ss.Size);
        }

        /// <summary>
        /// Tests that the default flavor is cherry
        /// </summary>
        [Fact]
        public void FlavorShouldBeCherryByDefault()
        {
            SailorSoda ss = new SailorSoda();
            Assert.Equal(SodaFlavor.Cherry, ss.Flavor);
        }

        /// <summary>
        /// Tests ice variable can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            SailorSoda mm = new SailorSoda();
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
            SailorSoda mm = new SailorSoda();
            mm.Size = Size.Large;
            Assert.Equal(Size.Large, mm.Size);
            mm.Size = Size.Medium;
            Assert.Equal(Size.Medium, mm.Size);
            mm.Size = Size.Small;
            Assert.Equal(Size.Small, mm.Size);
        }

        /// <summary>
        /// Tests that the flavors can be changed and set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavor()
        {
            SailorSoda ss = new SailorSoda();
            ss.Flavor = SodaFlavor.Blackberry;
            Assert.Equal(SodaFlavor.Blackberry, ss.Flavor);
            ss.Flavor = SodaFlavor.Cherry;
            Assert.Equal(SodaFlavor.Cherry, ss.Flavor);
            ss.Flavor = SodaFlavor.Grapefruit;
            Assert.Equal(SodaFlavor.Grapefruit, ss.Flavor);
            ss.Flavor = SodaFlavor.Lemon;
            Assert.Equal(SodaFlavor.Lemon, ss.Flavor);
            ss.Flavor = SodaFlavor.Peach;
            Assert.Equal(SodaFlavor.Peach, ss.Flavor);
            ss.Flavor = SodaFlavor.Watermelon;
            Assert.Equal(SodaFlavor.Watermelon, ss.Flavor);
        }

        /// <summary>
        /// Tests all the size possibilities for the price 
        /// </summary>
        /// <param name="size">Size of drink</param>
        /// <param name="price">Price based on size</param>
        [Theory]
        [InlineData(Size.Small, 1.42)]
        [InlineData(Size.Medium, 1.74)]
        [InlineData(Size.Large, 2.07)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            SailorSoda mm = new SailorSoda();
            mm.Size = size;
            Assert.Equal(price, mm.Price);
        }

        /// <summary>
        /// Tests the proper calorie count goes with the right size
        /// </summary>
        /// <param name="size">Size of drink</param>
        /// <param name="cal">Calorie count of the drink</param>
        [Theory]
        [InlineData(Size.Small, 117)]
        [InlineData(Size.Medium, 153)]
        [InlineData(Size.Large, 205)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            SailorSoda mm = new SailorSoda();
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
            SailorSoda mm = new SailorSoda();
            mm.Ice = includeIce;
            if (!includeIce)
            {
                Assert.Contains("Hold ice", mm.SpecialInstructions);
            }
            else
            {
                Assert.Empty(mm.SpecialInstructions);
            }
        }

        /// <summary>
        /// Tests ToString() method fo drink based on size and flavor
        /// </summary>
        /// <param name="flavor"></param>
        /// <param name="size"></param>
        /// <param name="name"></param>
        [Theory]
        [InlineData(SodaFlavor.Cherry, Size.Small, "Small Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Medium, "Medium Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Large, "Large Cherry Sailor Soda")]

        [InlineData(SodaFlavor.Blackberry, Size.Small, "Small Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Medium, "Medium Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Large, "Large Blackberry Sailor Soda")]

        [InlineData(SodaFlavor.Grapefruit, Size.Small, "Small Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Medium, "Medium Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Large, "Large Grapefruit Sailor Soda")]

        [InlineData(SodaFlavor.Lemon, Size.Small, "Small Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Medium, "Medium Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Large, "Large Lemon Sailor Soda")]

        [InlineData(SodaFlavor.Peach, Size.Small, "Small Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Medium, "Medium Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Large, "Large Peach Sailor Soda")]

        [InlineData(SodaFlavor.Watermelon, Size.Small, "Small Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Medium, "Medium Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Large, "Large Watermelon Sailor Soda")]
        public void ShouldHaveCorrectToStringBasedOnSizeAndFlavor(SodaFlavor flavor, Size size, string name)
        {
            SailorSoda ss = new SailorSoda();
            ss.Flavor = flavor;
            ss.Size = size;
            Assert.Equal(name, ss.ToString());
        }

        /// <summary>
        /// tests that Ice property is notified when changed
        /// </summary>
        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            SailorSoda ss = new SailorSoda();

            Assert.PropertyChanged(ss, "Ice", () =>
            {
                ss.Ice = false;
            });

            Assert.PropertyChanged(ss, "Ice", () =>
            {
                ss.Ice = true;
            });
        }

        /// <summary>
        /// tests that SpecialInstructions property is notified when Ice is changed
        /// </summary>
        [Fact]
        public void ChangingIceNotifiesSpecialInstructions()
        {
            SailorSoda ss = new SailorSoda();

            Assert.PropertyChanged(ss, "SpecialInstructions", () =>
            {
                ss.Ice = false;
            });

            Assert.PropertyChanged(ss, "SpecialInstructions", () =>
            {
                ss.Ice = true;
            });

        }

        /// <summary>
        /// tests that Flavor property is notified when changed
        /// </summary>
        [Fact]
        public void ChangingFlavorNotifiesSizeProperty()
        {
            SailorSoda ss = new SailorSoda();

            Assert.PropertyChanged(ss, "Flavor", () =>
            {
                ss.Flavor = SodaFlavor.Blackberry;
            });

            Assert.PropertyChanged(ss, "Flavor", () =>
            {
                ss.Flavor = SodaFlavor.Cherry;
            });

            Assert.PropertyChanged(ss, "Flavor", () =>
            {
                ss.Flavor = SodaFlavor.Grapefruit;
            });

            Assert.PropertyChanged(ss, "Flavor", () =>
            {
                ss.Flavor = SodaFlavor.Lemon;
            });

            Assert.PropertyChanged(ss, "Flavor", () =>
            {
                ss.Flavor = SodaFlavor.Watermelon;
            });

            Assert.PropertyChanged(ss, "Flavor", () =>
            {
                ss.Flavor = SodaFlavor.Peach;
            });
        }

        /// <summary>
        /// tests that Size property is notified when changed
        /// </summary>
        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            SailorSoda ss = new SailorSoda();

            Assert.PropertyChanged(ss, "Size", () =>
            {
                ss.Size = Size.Large;
            });

            Assert.PropertyChanged(ss, "Size", () =>
            {
                ss.Size = Size.Medium;
            });

            Assert.PropertyChanged(ss, "Size", () =>
            {
                ss.Size = Size.Large;
            });
        }

        /// <summary>
        /// tests that Price property is notified when Size is changed
        /// </summary>
        [Fact]
        public void ChangingSizeNotifiesPriceProperty()
        {
            SailorSoda ss = new SailorSoda();

            Assert.PropertyChanged(ss, "Price", () =>
            {
                ss.Size = Size.Large;
            });

            Assert.PropertyChanged(ss, "Price", () =>
            {
                ss.Size = Size.Medium;
            });

            Assert.PropertyChanged(ss, "Price", () =>
            {
                ss.Size = Size.Large;
            });
        }

        /// <summary>
        /// tests that Calories property is notified when Size is changed
        /// </summary>
        [Fact]
        public void ChangingSizeNotifiesCaloriesProperty()
        {
            SailorSoda ss = new SailorSoda();

            Assert.PropertyChanged(ss, "Calories", () =>
            {
                ss.Size = Size.Large;
            });

            Assert.PropertyChanged(ss, "Calories", () =>
            {
                ss.Size = Size.Medium;
            });

            Assert.PropertyChanged(ss, "Calories", () =>
            {
                ss.Size = Size.Large;
            });
        }


        /// <summary>
        /// tests that this class inherits from the INotifyPropertyChanged interface
        /// </summary>
        [Fact]
        public void ShouldBeAnINotifyPropertyChanged()
        {
            SailorSoda ss = new SailorSoda();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(ss);
        }

    }
}
