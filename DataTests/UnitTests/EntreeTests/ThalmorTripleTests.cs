﻿/*
 * Author: Zachery Brunner
 * Class: ThalmoreTripleTests.cs
 * Purpose: Test the ThalmoreTriple.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// testing class for triple thalmor burger
    /// </summary>
    public class ThalmoreTripleTests
    {
        /// <summary>
        /// ensures this class inherits from the IOrderItem interface
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            ThalmoreTriple tt = new ThalmoreTriple();
            Assert.IsAssignableFrom<IOrderItem>(tt);
        }

        /// <summary>
        /// ensures this class inherits from the base Entree class
        /// </summary>
        [Fact]
        public void ShouldBeAnEntree()
        {
            ThalmoreTriple tt = new ThalmoreTriple();
            Assert.IsAssignableFrom<Entree>(tt);
        }

        /// <summary>
        /// Tests that the bun is true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            ThalmoreTriple tt = new ThalmoreTriple();
            Assert.True(tt.Bun);
        }

        /// <summary>
        /// Tests that the ketchup is true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            ThalmoreTriple tt = new ThalmoreTriple();
            Assert.True(tt.Ketchup);
        }

        /// <summary>
        /// Tests that the mustard is true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            ThalmoreTriple tt = new ThalmoreTriple();
            Assert.True(tt.Mustard);
        }

        /// <summary>
        /// Tests that the pickles is true by default
        /// </summary>
        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            ThalmoreTriple tt = new ThalmoreTriple();
            Assert.True(tt.Pickle);
        }

        /// <summary>
        /// Tests that the cheese is true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            ThalmoreTriple tt = new ThalmoreTriple();
            Assert.True(tt.Cheese);
        }

        /// <summary>
        /// Tests that the tomato is true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            ThalmoreTriple tt = new ThalmoreTriple();
            Assert.True(tt.Tomato);
        }

        /// <summary>
        /// Tests that the lettuce is true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            ThalmoreTriple tt = new ThalmoreTriple();
            Assert.True(tt.Lettuce);
        }

        /// <summary>
        /// Tests that the mayo is true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            ThalmoreTriple tt = new ThalmoreTriple();
            Assert.True(tt.Mayo);
        }

        /// <summary>
        /// Test that bacon is true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeBaconByDefault()
        {
            ThalmoreTriple tt = new ThalmoreTriple();
            Assert.True(tt.Bacon);
        }

        /// <summary>
        /// Tests that the egg is true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            ThalmoreTriple tt = new ThalmoreTriple();
            Assert.True(tt.Egg);
        }

        /// <summary>
        /// Tests that bun can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            ThalmoreTriple tt = new ThalmoreTriple();
            tt.Bun = false;
            Assert.False(tt.Bun);
            tt.Bun = true;
            Assert.True(tt.Bun);
        }

        /// <summary>
        /// Tests that ketchup can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            ThalmoreTriple tt = new ThalmoreTriple();
            tt.Ketchup = false;
            Assert.False(tt.Ketchup);
            tt.Ketchup = true;
            Assert.True(tt.Ketchup);
        }

        /// <summary>
        /// Tests that mustard can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            ThalmoreTriple tt = new ThalmoreTriple();
            tt.Mustard = false;
            Assert.False(tt.Mustard);
            tt.Mustard = true;
            Assert.True(tt.Mustard);
        }

        /// <summary>
        /// Tests that pickle can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            ThalmoreTriple tt = new ThalmoreTriple();
            tt.Pickle = false;
            Assert.False(tt.Pickle);
            tt.Pickle = true;
            Assert.True(tt.Pickle);
        }

        /// <summary>
        /// Tests that cheese can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            ThalmoreTriple tt = new ThalmoreTriple();
            tt.Cheese = false;
            Assert.False(tt.Cheese);
            tt.Cheese = true;
            Assert.True(tt.Cheese);
        }

        /// <summary>
        /// Tests that tomato can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            ThalmoreTriple tt = new ThalmoreTriple();
            tt.Tomato = false;
            Assert.False(tt.Tomato);
            tt.Tomato = true;
            Assert.True(tt.Tomato);
        }

        /// <summary>
        /// Tests that lettuce can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            ThalmoreTriple tt = new ThalmoreTriple();
            tt.Lettuce = false;
            Assert.False(tt.Lettuce);
            tt.Lettuce = true;
            Assert.True(tt.Lettuce);
        }

        /// <summary>
        /// Tests that mayo can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            ThalmoreTriple tt = new ThalmoreTriple();
            tt.Mayo = false;
            Assert.False(tt.Mayo);
            tt.Mayo = true;
            Assert.True(tt.Mayo);
        }

        /// <summary>
        /// Tests that bacon can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            ThalmoreTriple tt = new ThalmoreTriple();
            tt.Bacon = false;
            Assert.False(tt.Bacon);
            tt.Bacon = true;
            Assert.True(tt.Bacon);
        }

        /// <summary>
        /// Tests that egg can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            ThalmoreTriple tt = new ThalmoreTriple();
            tt.Egg = false;
            Assert.False(tt.Egg);
            tt.Egg = true;
            Assert.True(tt.Egg);
        }


        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThalmoreTriple tt = new ThalmoreTriple();
            Assert.Equal(8.32, tt.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThalmoreTriple tt = new ThalmoreTriple();
            Assert.Equal((uint)943, tt.Calories);
        }

        /// <summary>
        /// Tests that the special instructions are met
        /// </summary>
        /// <param name="includeBun">vaue of bun</param>
        /// <param name="includeKetchup">value of ketchup</param>
        /// <param name="includeMustard">value of mustard</param>
        /// <param name="includePickle">value of pickle</param>
        /// <param name="includeCheese">value of cheese</param>
        /// <param name="includeTomato">value of tomato</param>
        /// <param name="includeLettuce">value of lettuce</param>
        /// <param name="includeMayo">value of mayo</param>
        /// <param name="includeBacon">value of bacon</param>
        /// <param name="includeEgg">value of egg</param>
        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo,
                                                                    bool includeBacon, bool includeEgg)
        {
            ThalmoreTriple tt = new ThalmoreTriple();
            tt.Bun = includeBun;
            tt.Ketchup = includeKetchup;
            tt.Mustard = includeMustard;
            tt.Pickle = includePickle;
            tt.Cheese = includeCheese;
            tt.Tomato = includeTomato;
            tt.Lettuce = includeLettuce;
            tt.Mayo = includeMayo;
            tt.Bacon = includeBacon;
            tt.Egg = includeEgg;

            if (includeBun)
            {
                Assert.Empty(tt.SpecialInstructions);
            }
            else if (!includeBun)
            {
                Assert.Contains("Hold bun", tt.SpecialInstructions);
                Assert.Contains("Hold ketchup", tt.SpecialInstructions);
                Assert.Contains("Hold mustard", tt.SpecialInstructions);
                Assert.Contains("Hold pickle", tt.SpecialInstructions);
                Assert.Contains("Hold cheese", tt.SpecialInstructions);
                Assert.Contains("Hold tomato", tt.SpecialInstructions);
                Assert.Contains("Hold lettuce", tt.SpecialInstructions);
                Assert.Contains("Hold mayo", tt.SpecialInstructions);
                Assert.Contains("Hold egg", tt.SpecialInstructions);
                Assert.Contains("Hold bacon", tt.SpecialInstructions);

            }
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThalmoreTriple tt = new ThalmoreTriple();
            Assert.Equal("Thalmor Triple", tt.ToString());
        }


        /// <summary>
        /// tests that Bun property is notified when changed
        /// </summary>
        [Fact]
        public void ChangingBunNotifiesBunProperty()
        {
            ThalmoreTriple tt = new ThalmoreTriple();

            Assert.PropertyChanged(tt, "Bun", () =>
            {
                tt.Bun = false;
            });

            Assert.PropertyChanged(tt, "Bun", () =>
            {
                tt.Bun = true;
            });
        }

        /// <summary>
        /// tests that SpecialInstructions property is notified when Bun is changed
        /// </summary>
        [Fact]
        public void ChangingBunNotifiesSpecialInstructionsProperty()
        {
            ThalmoreTriple tt = new ThalmoreTriple();

            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Bun = false;
            });

            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Bun = true;
            });
        }

        /// <summary>
        /// tests that Ketchup property is notified when changed
        /// </summary>
        [Fact]
        public void ChangingKetchupNotifiesKetchupProperty()
        {
            ThalmoreTriple tt = new ThalmoreTriple();

            Assert.PropertyChanged(tt, "Ketchup", () =>
            {
                tt.Ketchup = false;
            });

            Assert.PropertyChanged(tt, "Ketchup", () =>
            {
                tt.Ketchup = true;
            });
        }

        /// <summary>
        /// tests that SpecialInstructions property is notified when ketchip is changed
        /// </summary>
        [Fact]
        public void ChangingKetchupNotifiesSpecialInstructionsProperty()
        {
            ThalmoreTriple tt = new ThalmoreTriple();

            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Ketchup = false;
            });

            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Ketchup = true;
            });
        }

        /// <summary>
        /// tests that Mustard property is notified when changed
        /// </summary>
        [Fact]
        public void ChangingMustardNotifiesMustardProperty()
        {
            ThalmoreTriple tt = new ThalmoreTriple();

            Assert.PropertyChanged(tt, "Mustard", () =>
            {
                tt.Mustard = false;
            });

            Assert.PropertyChanged(tt, "Mustard", () =>
            {
                tt.Mustard = true;
            });
        }

        /// <summary>
        /// tests that SpecialInstructions property is notified when Mustard is changed
        /// </summary>
        [Fact]
        public void ChangingMustardNotifiesSpecialInstructionsProperty()
        {
            ThalmoreTriple tt = new ThalmoreTriple();

            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Mustard = false;
            });

            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Mustard = true;
            });
        }

        /// <summary>
        /// tests that Pickle property is notified when changed
        /// </summary>
        [Fact]
        public void ChangingPickleNotifiesPickleProperty()
        {
            ThalmoreTriple tt = new ThalmoreTriple();

            Assert.PropertyChanged(tt, "Pickle", () =>
            {
                tt.Pickle = false;
            });

            Assert.PropertyChanged(tt, "Pickle", () =>
            {
                tt.Pickle = true;
            });
        }

        /// <summary>
        /// tests that SpecialInstructions property is notified when Pickle is changed
        /// </summary>
        [Fact]
        public void ChangingPickleNotifiesSpecialInstructionsProperty()
        {
            ThalmoreTriple tt = new ThalmoreTriple();

            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Pickle = false;
            });

            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Pickle = true;
            });
        }

        /// <summary>
        /// tests that Cheese property is notified when changed
        /// </summary>
        [Fact]
        public void ChangingCheeseNotifiesCheeseProperty()
        {
            ThalmoreTriple tt = new ThalmoreTriple();

            Assert.PropertyChanged(tt, "Cheese", () =>
            {
                tt.Cheese = false;
            });

            Assert.PropertyChanged(tt, "Cheese", () =>
            {
                tt.Cheese = true;
            });
        }

        /// <summary>
        /// tests that SpecialInstructions property is notified when Cheese is changed
        /// </summary>
        [Fact]
        public void ChangingCheeseNotifiesSpecialInstructionsProperty()
        {
            ThalmoreTriple tt = new ThalmoreTriple();

            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Cheese = false;
            });

            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Cheese = true;
            });
        }

        /// <summary>
        /// tests that Tomato property is notified when changed
        /// </summary>
        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            ThalmoreTriple tt = new ThalmoreTriple();

            Assert.PropertyChanged(tt, "Tomato", () =>
            {
                tt.Tomato = false;
            });

            Assert.PropertyChanged(tt, "Tomato", () =>
            {
                tt.Tomato = true;
            });
        }

        /// <summary>
        /// tests that SpecialInstructions property is notified when Tomato is changed
        /// </summary>
        [Fact]
        public void ChangingTomatoNotifiesSpecialInstructionsProperty()
        {
            ThalmoreTriple tt = new ThalmoreTriple();

            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Tomato = false;
            });

            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Tomato = true;
            });
        }

        /// <summary>
        /// tests that Lettuce property is notified when changed
        /// </summary>
        [Fact]
        public void ChangingLettuceNotifiesLettuceProperty()
        {
            ThalmoreTriple tt = new ThalmoreTriple();

            Assert.PropertyChanged(tt, "Lettuce", () =>
            {
                tt.Lettuce = false;
            });

            Assert.PropertyChanged(tt, "Lettuce", () =>
            {
                tt.Lettuce = true;
            });
        }

        /// <summary>
        /// tests that SpecialInstructions property is notified when Lettuce is changed
        /// </summary>
        [Fact]
        public void ChangingLettuceNotifiesSpecialInstructionsProperty()
        {
            ThalmoreTriple tt = new ThalmoreTriple();

            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Lettuce = false;
            });

            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Lettuce = true;
            });
        }

        /// <summary>
        /// tests that Mayo property is notified when changed
        /// </summary>
        [Fact]
        public void ChangingMayoNotifiesMayoProperty()
        {
            ThalmoreTriple tt = new ThalmoreTriple();

            Assert.PropertyChanged(tt, "Mayo", () =>
            {
                tt.Mayo = false;
            });

            Assert.PropertyChanged(tt, "Mayo", () =>
            {
                tt.Mayo = true;
            });
        }

        /// <summary>
        /// tests that SpecialInstructions property is notified when Mayo is changed
        /// </summary>
        [Fact]
        public void ChangingMayoNotifiesSpecialInstructionsProperty()
        {
            ThalmoreTriple tt = new ThalmoreTriple();

            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Mayo = false;
            });

            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Mayo = true;
            });
        }

        /// <summary>
        /// tests that Bacon property is notified when changed
        /// </summary>
        [Fact]
        public void ChangingBaconNotifiesBaconProperty()
        {
            ThalmoreTriple tt = new ThalmoreTriple();

            Assert.PropertyChanged(tt, "Bacon", () =>
            {
                tt.Bacon = false;
            });

            Assert.PropertyChanged(tt, "Bacon", () =>
            {
                tt.Bacon = true;
            });
        }

        /// <summary>
        /// tests that SpecialInstructions property is notified when Bacon is changed
        /// </summary>
        [Fact]
        public void ChangingBaconNotifiesSpecialInstructionsProperty()
        {
            ThalmoreTriple tt = new ThalmoreTriple();

            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Bacon = false;
            });

            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Bacon = true;
            });
        }

        /// <summary>
        /// tests that Egg property is notified when changed
        /// </summary>
        [Fact]
        public void ChangingEggNotifiesEggProperty()
        {
            ThalmoreTriple tt = new ThalmoreTriple();

            Assert.PropertyChanged(tt, "Egg", () =>
            {
                tt.Egg = false;
            });

            Assert.PropertyChanged(tt, "Egg", () =>
            {
                tt.Egg = true;
            });
        }

        /// <summary>
        /// tests that SpecialInstructions property is notified when Egg is changed
        /// </summary>
        [Fact]
        public void ChangingEggNotifiesSpecialInstructionsProperty()
        {
            ThalmoreTriple tt = new ThalmoreTriple();

            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Egg = false;
            });

            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Egg = true;
            });
        }

        /// <summary>
        /// tests that this class inherits from the INotifyPropertyChanged interface
        /// </summary>
        [Fact]
        public void ShouldBeAnINotifyPropertyChanged()
        {
            ThalmoreTriple tt = new ThalmoreTriple();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(tt);
        }

    }
}