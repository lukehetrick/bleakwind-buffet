/*
 * Author: Zachery Brunner
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// testing class for double draugr burger
    /// </summary>
    public class DoubleDraugrTests
    {
        /// <summary>
        /// ensures this class inherits from the IOrderItem interface
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.IsAssignableFrom<IOrderItem>(dd);
        }

        /// <summary>
        /// ensures this class inherits from the base Entree class
        /// </summary>
        [Fact]
        public void ShouldBeAnEntree()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.IsAssignableFrom<Entree>(dd);
        }

        /// <summary>
        /// Tests that the bun is true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Bun);
        }

        /// <summary>
        /// Tests that the ketchup is true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Ketchup);
        }

        /// <summary>
        /// Tests that the mustard is true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Mustard);
        }

        /// <summary>
        /// Tests that the pickles is true by default
        /// </summary>
        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Pickle);
        }

        /// <summary>
        /// Tests that the cheese is true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Cheese);
        }

        /// <summary>
        /// Tests that the tomato is true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Tomato);
        }

        /// <summary>
        /// Tests that the lettuce is true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Lettuce);
        }

        /// <summary>
        /// Tests that the mayo is true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Mayo);
        }

        /// <summary>
        /// Tests that bun can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Bun = false;
            Assert.False(dd.Bun);
            dd.Bun = true;
            Assert.True(dd.Bun);
        }

        /// <summary>
        /// Tests that ketchup can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Ketchup = false;
            Assert.False(dd.Ketchup);
            dd.Ketchup = true;
            Assert.True(dd.Ketchup);
        }

        /// <summary>
        /// Tests that mustard can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Mustard = false;
            Assert.False(dd.Mustard);
            dd.Mustard = true;
            Assert.True(dd.Mustard);
        }

        /// <summary>
        /// Tests that pickle can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Pickle = false;
            Assert.False(dd.Pickle);
            dd.Pickle = true;
            Assert.True(dd.Pickle);
        }

        /// <summary>
        /// Tests that cheese can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Cheese = false;
            Assert.False(dd.Cheese);
            dd.Cheese = true;
            Assert.True(dd.Cheese);
        }

        /// <summary>
        /// Tests that tomato can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Tomato = false;
            Assert.False(dd.Tomato);
            dd.Tomato = true;
            Assert.True(dd.Tomato);
        }

        /// <summary>
        /// Tests that lettuce can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Lettuce = false;
            Assert.False(dd.Lettuce);
            dd.Lettuce = true;
            Assert.True(dd.Lettuce);
        }

        /// <summary>
        /// Tests that mayo can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Mayo = false;
            Assert.False(dd.Mayo);
            dd.Mayo = true;
            Assert.True(dd.Mayo);
        }

        /// <summary>
        /// tests that price of the burger matches the correct price
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.Equal(7.32, dd.Price);
        }

        /// <summary>
        /// tests that calories of the burger matches the correct Calories
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.Equal((uint)843, dd.Calories);
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
        [Theory]
        [InlineData(true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo)
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Bun = includeBun;
            dd.Ketchup = includeKetchup;
            dd.Mustard = includeMustard;
            dd.Pickle = includePickle;
            dd.Cheese = includeCheese;
            dd.Tomato = includeTomato;
            dd.Lettuce = includeLettuce;
            dd.Mayo = includeMayo;

            if (includeBun)
            {
                Assert.Empty(dd.SpecialInstructions);
            }
            else if (!includeBun)
            {
                Assert.Contains("Hold bun", dd.SpecialInstructions);
                Assert.Contains("Hold ketchup", dd.SpecialInstructions);
                Assert.Contains("Hold mustard", dd.SpecialInstructions);
                Assert.Contains("Hold pickle", dd.SpecialInstructions);
                Assert.Contains("Hold cheese", dd.SpecialInstructions);
                Assert.Contains("Hold tomato", dd.SpecialInstructions);
                Assert.Contains("Hold lettuce", dd.SpecialInstructions);
                Assert.Contains("Hold mayo", dd.SpecialInstructions);

            }
        }

        /// <summary>
        /// Tests ToString() method of drink based on size
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.Equal("Double Draugr", dd.ToString());
        }

        /// <summary>
        /// tests that Bun property is notified when changed
        /// </summary>
        [Fact]
        public void ChangingBunNotifiesBunProperty()
        {
            DoubleDraugr dd = new DoubleDraugr();

            Assert.PropertyChanged(dd, "Bun", () =>
            {
                dd.Bun = false;
            });

            Assert.PropertyChanged(dd, "Bun", () =>
            {
                dd.Bun = true;
            });
        }

        /// <summary>
        /// tests that SpecialInstructions property is notified when Bun is changed
        /// </summary>
        [Fact]
        public void ChangingBunNotifiesSpecialInstructionsProperty()
        {
            DoubleDraugr dd = new DoubleDraugr();

            Assert.PropertyChanged(dd, "SpecialInstructions", () =>
            {
                dd.Bun = false;
            });

            Assert.PropertyChanged(dd, "SpecialInstructions", () =>
            {
                dd.Bun = true;
            });
        }

        /// <summary>
        /// tests that Ketchup property is notified when changed
        /// </summary>
        [Fact]
        public void ChangingKetchupNotifiesKetchupProperty()
        {
            DoubleDraugr dd = new DoubleDraugr();

            Assert.PropertyChanged(dd, "Ketchup", () =>
            {
                dd.Ketchup = false;
            });

            Assert.PropertyChanged(dd, "Ketchup", () =>
            {
                dd.Ketchup = true;
            });
        }

        /// <summary>
        /// tests that SpecialInstructions property is notified when ketchip is changed
        /// </summary>
        [Fact]
        public void ChangingKetchupNotifiesSpecialInstructionsProperty()
        {
            DoubleDraugr dd = new DoubleDraugr();

            Assert.PropertyChanged(dd, "SpecialInstructions", () =>
            {
                dd.Ketchup = false;
            });

            Assert.PropertyChanged(dd, "SpecialInstructions", () =>
            {
                dd.Ketchup = true;
            });
        }

        /// <summary>
        /// tests that Mustard property is notified when changed
        /// </summary>
        [Fact]
        public void ChangingMustardNotifiesMustardProperty()
        {
            DoubleDraugr dd = new DoubleDraugr();

            Assert.PropertyChanged(dd, "Mustard", () =>
            {
                dd.Mustard = false;
            });

            Assert.PropertyChanged(dd, "Mustard", () =>
            {
                dd.Mustard = true;
            });
        }

        /// <summary>
        /// tests that SpecialInstructions property is notified when Mustard is changed
        /// </summary>
        [Fact]
        public void ChangingMustardNotifiesSpecialInstructionsProperty()
        {
            DoubleDraugr dd = new DoubleDraugr();

            Assert.PropertyChanged(dd, "SpecialInstructions", () =>
            {
                dd.Mustard = false;
            });

            Assert.PropertyChanged(dd, "SpecialInstructions", () =>
            {
                dd.Mustard = true;
            });
        }

        /// <summary>
        /// tests that Pickle property is notified when changed
        /// </summary>
        [Fact]
        public void ChangingPickleNotifiesPickleProperty()
        {
            DoubleDraugr dd = new DoubleDraugr();

            Assert.PropertyChanged(dd, "Pickle", () =>
            {
                dd.Pickle = false;
            });

            Assert.PropertyChanged(dd, "Pickle", () =>
            {
                dd.Pickle = true;
            });
        }

        /// <summary>
        /// tests that SpecialInstructions property is notified when Pickle is changed
        /// </summary>
        [Fact]
        public void ChangingPickleNotifiesSpecialInstructionsProperty()
        {
            DoubleDraugr dd = new DoubleDraugr();

            Assert.PropertyChanged(dd, "SpecialInstructions", () =>
            {
                dd.Pickle = false;
            });

            Assert.PropertyChanged(dd, "SpecialInstructions", () =>
            {
                dd.Pickle = true;
            });
        }

        /// <summary>
        /// tests that Cheese property is notified when changed
        /// </summary>
        [Fact]
        public void ChangingCheeseNotifiesCheeseProperty()
        {
            DoubleDraugr dd = new DoubleDraugr();

            Assert.PropertyChanged(dd, "Cheese", () =>
            {
                dd.Cheese = false;
            });

            Assert.PropertyChanged(dd, "Cheese", () =>
            {
                dd.Cheese = true;
            });
        }

        /// <summary>
        /// tests that SpecialInstructions property is notified when Cheese is changed
        /// </summary>
        [Fact]
        public void ChangingCheeseNotifiesSpecialInstructionsProperty()
        {
            DoubleDraugr dd = new DoubleDraugr();

            Assert.PropertyChanged(dd, "SpecialInstructions", () =>
            {
                dd.Cheese = false;
            });

            Assert.PropertyChanged(dd, "SpecialInstructions", () =>
            {
                dd.Cheese = true;
            });
        }

        /// <summary>
        /// tests that Tomato property is notified when changed
        /// </summary>
        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            DoubleDraugr dd = new DoubleDraugr();

            Assert.PropertyChanged(dd, "Tomato", () =>
            {
                dd.Tomato = false;
            });

            Assert.PropertyChanged(dd, "Tomato", () =>
            {
                dd.Tomato = true;
            });
        }

        /// <summary>
        /// tests that SpecialInstructions property is notified when Tomato is changed
        /// </summary>
        [Fact]
        public void ChangingTomatoNotifiesSpecialInstructionsProperty()
        {
            DoubleDraugr dd = new DoubleDraugr();

            Assert.PropertyChanged(dd, "SpecialInstructions", () =>
            {
                dd.Tomato = false;
            });

            Assert.PropertyChanged(dd, "SpecialInstructions", () =>
            {
                dd.Tomato = true;
            });
        }

        /// <summary>
        /// tests that Lettuce property is notified when changed
        /// </summary>
        [Fact]
        public void ChangingLettuceNotifiesLettuceProperty()
        {
            DoubleDraugr dd = new DoubleDraugr();

            Assert.PropertyChanged(dd, "Lettuce", () =>
            {
                dd.Lettuce = false;
            });

            Assert.PropertyChanged(dd, "Lettuce", () =>
            {
                dd.Lettuce = true;
            });
        }

        /// <summary>
        /// tests that SpecialInstructions property is notified when Lettuce is changed
        /// </summary>
        [Fact]
        public void ChangingLettuceNotifiesSpecialInstructionsProperty()
        {
            DoubleDraugr dd = new DoubleDraugr();

            Assert.PropertyChanged(dd, "SpecialInstructions", () =>
            {
                dd.Lettuce = false;
            });

            Assert.PropertyChanged(dd, "SpecialInstructions", () =>
            {
                dd.Lettuce = true;
            });
        }

        /// <summary>
        /// tests that Mayo property is notified when changed
        /// </summary>
        [Fact]
        public void ChangingMayoNotifiesMayoProperty()
        {
            DoubleDraugr dd = new DoubleDraugr();

            Assert.PropertyChanged(dd, "Mayo", () =>
            {
                dd.Mayo = false;
            });

            Assert.PropertyChanged(dd, "Mayo", () =>
            {
                dd.Mayo = true;
            });
        }

        /// <summary>
        /// tests that SpecialInstructions property is notified when Mayo is changed
        /// </summary>
        [Fact]
        public void ChangingMayoNotifiesSpecialInstructionsProperty()
        {
            DoubleDraugr dd = new DoubleDraugr();

            Assert.PropertyChanged(dd, "SpecialInstructions", () =>
            {
                dd.Mayo = false;
            });

            Assert.PropertyChanged(dd, "SpecialInstructions", () =>
            {
                dd.Mayo = true;
            });
        }

        /// <summary>
        /// tests that this class inherits from the INotifyPropertyChanged interface
        /// </summary>
        [Fact]
        public void ShouldBeAnINotifyPropertyChanged()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(dd);
        }

    }
}