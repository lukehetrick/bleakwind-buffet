﻿/*
 * Author: Zachery Brunner
 * Class: BriarheartBurgerTests.cs
 * Purpose: Test the BriarheartBurger.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// testing class for Briarheart burger
    /// </summary>
    public class BriarheartBurgerTests
    {
        /// <summary>
        /// ensures this class inherits from IOrderItem interface
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.IsAssignableFrom<IOrderItem>(bb);
        }

        /// <summary>
        /// ensures this class inherits from the base Entree class
        /// </summary>
        [Fact]
        public void ShouldBeAnEntree()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.IsAssignableFrom<Entree>(bb);
        }

        /// <summary>
        /// Tests that the bun is true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Bun);
        }

        /// <summary>
        /// Tests that the ketchup is true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Ketchup);
        }

        /// <summary>
        /// Tests that the mustard is true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Mustard);
        }

        /// <summary>
        /// Tests that the pickles is true by default
        /// </summary>
        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Pickle);
        }

        /// <summary>
        /// Tests that the cheese is true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Cheese);
        }

        /// <summary>
        /// Tests that bun can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Bun = false;
            Assert.False(bb.Bun);
            bb.Bun = true;
            Assert.True(bb.Bun);
        }

        /// <summary>
        /// Tests that ketchup can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Ketchup = false;
            Assert.False(bb.Ketchup);
            bb.Ketchup = true;
            Assert.True(bb.Ketchup);
        }

        /// <summary>
        /// Tests that mustard can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Mustard = false;
            Assert.False(bb.Mustard);
            bb.Mustard = true;
            Assert.True(bb.Mustard);
        }

        /// <summary>
        /// Tests that pickle can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Pickle = false;
            Assert.False(bb.Pickle);
            bb.Pickle = true;
            Assert.True(bb.Pickle);
        }

        /// <summary>
        /// Tests that cheese can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Cheese = false;
            Assert.False(bb.Cheese);
            bb.Cheese = true;
            Assert.True(bb.Cheese);
        }
        
        /// <summary>
        /// tests that price of the burger matches the correct price
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.Equal(6.32, bb.Price);
        }

        /// <summary>
        /// tests that calories of the burger matches the correct Calories
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.Equal((uint)743, bb.Calories);
        }

        /// <summary>
        /// Tests that the special instructions are met
        /// </summary>
        /// <param name="includeBun">vaue of bun</param>
        /// <param name="includeKetchup">value of ketchup</param>
        /// <param name="includeMustard">value of mustard</param>
        /// <param name="includePickle">value of pickle</param>
        /// <param name="includeCheese">value of cheese</param>
        [Theory]
        [InlineData(true, true, true, true, true)]
        [InlineData(false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese)
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Bun = includeBun;
            bb.Ketchup = includeKetchup;
            bb.Mustard = includeMustard;
            bb.Pickle = includePickle;
            bb.Cheese = includeCheese;

            if(includeBun)
            {
                Assert.Empty(bb.SpecialInstructions);
            }
            else if (!includeBun)
            {
                Assert.Contains("Hold bun", bb.SpecialInstructions);
                Assert.Contains("Hold ketchup", bb.SpecialInstructions);
                Assert.Contains("Hold mustard", bb.SpecialInstructions);
                Assert.Contains("Hold pickle", bb.SpecialInstructions);
                Assert.Contains("Hold cheese", bb.SpecialInstructions);
            }
        }

        /// <summary>
        /// Tests ToString() method of burger
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.Equal("Briarheart Burger", bb.ToString());
        }


        /// <summary>
        /// tests that Bun property is notified when changed
        /// </summary>
        [Fact]
        public void ChangingBunNotifiesBunProperty()
        {
            BriarheartBurger bb = new BriarheartBurger();

            Assert.PropertyChanged(bb, "Bun", () =>
            {
                bb.Bun = false;
            });

            Assert.PropertyChanged(bb, "Bun", () =>
            {
                bb.Bun = true;
            });
        }

        /// <summary>
        /// tests that SpecialInstructions property is notified when Bun is changed
        /// </summary>
        [Fact]
        public void ChangingBunNotifiesSpecialInstructionsProperty()
        {
            BriarheartBurger bb = new BriarheartBurger();

            Assert.PropertyChanged(bb, "SpecialInstructions", () =>
            {
                bb.Bun = false;
            });

            Assert.PropertyChanged(bb, "SpecialInstructions", () =>
            {
                bb.Bun = true;
            });
        }

        /// <summary>
        /// tests that Ketchup property is notified when changed
        /// </summary>
        [Fact]
        public void ChangingKetchupNotifiesKetchupProperty()
        {
            BriarheartBurger bb = new BriarheartBurger();

            Assert.PropertyChanged(bb, "Ketchup", () =>
            {
                bb.Ketchup = false;
            });

            Assert.PropertyChanged(bb, "Ketchup", () =>
            {
                bb.Ketchup = true;
            });
        }

        /// <summary>
        /// tests that SpecialInstructions property is notified when ketchip is changed
        /// </summary>
        [Fact]
        public void ChangingKetchupNotifiesSpecialInstructionsProperty()
        {
            BriarheartBurger bb = new BriarheartBurger();

            Assert.PropertyChanged(bb, "SpecialInstructions", () =>
            {
                bb.Ketchup = false;
            });

            Assert.PropertyChanged(bb, "SpecialInstructions", () =>
            {
                bb.Ketchup = true;
            });
        }

        /// <summary>
        /// tests that Mustard property is notified when changed
        /// </summary>
        [Fact]
        public void ChangingMustardNotifiesMustardProperty()
        {
            BriarheartBurger bb = new BriarheartBurger();

            Assert.PropertyChanged(bb, "Mustard", () =>
            {
                bb.Mustard = false;
            });

            Assert.PropertyChanged(bb, "Mustard", () =>
            {
                bb.Mustard = true;
            });
        }

        /// <summary>
        /// tests that SpecialInstructions property is notified when Mustard is changed
        /// </summary>
        [Fact]
        public void ChangingMustardNotifiesSpecialInstructionsProperty()
        {
            BriarheartBurger bb = new BriarheartBurger();

            Assert.PropertyChanged(bb, "SpecialInstructions", () =>
            {
                bb.Mustard = false;
            });

            Assert.PropertyChanged(bb, "SpecialInstructions", () =>
            {
                bb.Mustard = true;
            });
        }

        /// <summary>
        /// tests that Pickle property is notified when changed
        /// </summary>
        [Fact]
        public void ChangingPickleNotifiesPickleProperty()
        {
            BriarheartBurger bb = new BriarheartBurger();

            Assert.PropertyChanged(bb, "Pickle", () =>
            {
                bb.Pickle = false;
            });

            Assert.PropertyChanged(bb, "Pickle", () =>
            {
                bb.Pickle = true;
            });
        }

        /// <summary>
        /// tests that SpecialInstructions property is notified when Pickle is changed
        /// </summary>
        [Fact]
        public void ChangingPickleNotifiesSpecialInstructionsProperty()
        {
            BriarheartBurger bb = new BriarheartBurger();

            Assert.PropertyChanged(bb, "SpecialInstructions", () =>
            {
                bb.Pickle = false;
            });

            Assert.PropertyChanged(bb, "SpecialInstructions", () =>
            {
                bb.Pickle = true;
            });
        }

        /// <summary>
        /// tests that Cheese property is notified when changed
        /// </summary>
        [Fact]
        public void ChangingCheeseNotifiesCheeseProperty()
        {
            BriarheartBurger bb = new BriarheartBurger();

            Assert.PropertyChanged(bb, "Cheese", () =>
            {
                bb.Cheese = false;
            });

            Assert.PropertyChanged(bb, "Cheese", () =>
            {
                bb.Cheese = true;
            });
        }

        /// <summary>
        /// tests that SpecialInstructions property is notified when Cheese is changed
        /// </summary>
        [Fact]
        public void ChangingCheeseNotifiesSpecialInstructionsProperty()
        {
            BriarheartBurger bb = new BriarheartBurger();

            Assert.PropertyChanged(bb, "SpecialInstructions", () =>
            {
                bb.Cheese = false;
            });

            Assert.PropertyChanged(bb, "SpecialInstructions", () =>
            {
                bb.Cheese = true;
            });
        }

        /// <summary>
        /// tests that this class inherits from the INotifyPropertyChanged interface
        /// </summary>
        [Fact]
        public void ShouldBeAnINotifyPropertyChanged()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(bb);
        }
    }
}