/*
 * Author: Zachery Brunner
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// testing class for Garden Orc omelette
    /// </summary>
    public class GardenOrcOmeletteTests
    {
        /// <summary>
        /// ensures this class inherits from the IOrderItem interface
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.IsAssignableFrom<IOrderItem>(goo);
        }

        /// <summary>
        /// ensures this class inherits from the base Entree class
        /// </summary>
        [Fact]
        public void ShouldBeAnEntree()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.IsAssignableFrom<Entree>(goo);
        }

        /// <summary>
        /// Tests that the broccoli is true by default
        /// </summary>
        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.True(goo.Broccoli);
        }

        /// <summary>
        /// Tests that the mushrooms is true by default
        /// </summary>
        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.True(goo.Mushrooms);
        }

        /// <summary>
        /// Tests that the tomato is true by default
        /// </summary>
        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.True(goo.Tomato);
        }

        /// <summary>
        /// Tests that the cheddar is true by default
        /// </summary>
        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.True(goo.Cheddar);
        }

        /// <summary>
        /// Tests that Broccoli can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Broccoli = false;
            Assert.False(goo.Broccoli);
            goo.Broccoli = true;
            Assert.True(goo.Broccoli);
        }

        /// <summary>
        /// Tests that mushrooms can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Mushrooms = false;
            Assert.False(goo.Mushrooms);
            goo.Mushrooms = true;
            Assert.True(goo.Mushrooms);
        }

        /// <summary>
        /// Tests that tomato can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Tomato = false;
            Assert.False(goo.Tomato);
            goo.Tomato = true;
            Assert.True(goo.Tomato);
        }

        /// <summary>
        /// Tests that cheddar can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Cheddar = false;
            Assert.False(goo.Cheddar);
            goo.Cheddar = true;
            Assert.True(goo.Cheddar);
        }

        /// <summary>
        /// tests that price of the omelette matches the correct price
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.Equal(4.57, goo.Price);
        }

        /// <summary>
        /// tests that calories of the omelette matches the correct Calories
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.Equal((uint)404, goo.Calories);
        }

        /// <summary>
        /// Tests that special instructions are set
        /// </summary>
        /// <param name="includeBroccoli">value fo broccoli</param>
        /// <param name="includeMushrooms">value of mushrooms</param>
        /// <param name="includeTomato">value of tomato</param>
        /// <param name="includeCheddar">value of cheddar</param>
        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Broccoli = includeBroccoli;
            goo.Mushrooms = includeMushrooms;
            goo.Tomato = includeTomato;
            goo.Cheddar = includeCheddar;

            if (includeBroccoli)
            {
                Assert.Empty(goo.SpecialInstructions);
            }
            else if (!includeBroccoli)
            {
                Assert.Contains("Hold broccoli", goo.SpecialInstructions);
                Assert.Contains("Hold mushrooms", goo.SpecialInstructions);
                Assert.Contains("Hold tomato", goo.SpecialInstructions);
                Assert.Contains("Hold cheddar", goo.SpecialInstructions);                
            }
        }

        /// <summary>
        /// Tests ToString() method of omelette
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", goo.ToString());
        }

        /// <summary>
        /// tests that Cheddar property is notified when changed
        /// </summary>
        [Fact]
        public void ChangingCheddarNotifiesCheddarProperty()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();

            Assert.PropertyChanged(goo, "Cheddar", () =>
            {
                goo.Cheddar = false;
            });

            Assert.PropertyChanged(goo, "Cheddar", () =>
            {
                goo.Cheddar = true;
            });
        }

        /// <summary>
        /// tests that SpecialInstructions property is notified when Cheddar is changed
        /// </summary>
        [Fact]
        public void ChangingCheddarNotifiesSpecialInstructionsProperty()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();

            Assert.PropertyChanged(goo, "SpecialInstructions", () =>
            {
                goo.Cheddar = false;
            });

            Assert.PropertyChanged(goo, "SpecialInstructions", () =>
            {
                goo.Cheddar = true;
            });
        }

        /// <summary>
        /// tests that Tomato property is notified when changed
        /// </summary>
        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();

            Assert.PropertyChanged(goo, "Tomato", () =>
            {
                goo.Tomato = false;
            });

            Assert.PropertyChanged(goo, "Tomato", () =>
            {
                goo.Tomato = true;
            });
        }

        /// <summary>
        /// tests that SpecialInstructions property is notified when Tomato is changed
        /// </summary>
        [Fact]
        public void ChangingTomatoNotifiesSpecialInstructionsProperty()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();

            Assert.PropertyChanged(goo, "SpecialInstructions", () =>
            {
                goo.Tomato = false;
            });

            Assert.PropertyChanged(goo, "SpecialInstructions", () =>
            {
                goo.Tomato = true;
            });
        }

        /// <summary>
        /// tests that Mushrooms property is notified when changed
        /// </summary>
        [Fact]
        public void ChangingMushroomsNotifiesMushroomsProperty()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();

            Assert.PropertyChanged(goo, "Mushrooms", () =>
            {
                goo.Mushrooms = false;
            });

            Assert.PropertyChanged(goo, "Mushrooms", () =>
            {
                goo.Mushrooms = true;
            });
        }

        /// <summary>
        /// tests that SpecialInstructions property is notified when Mushrooms is changed
        /// </summary>
        [Fact]
        public void ChangingMushroomsNotifiesSpecialInstructionsProperty()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();

            Assert.PropertyChanged(goo, "SpecialInstructions", () =>
            {
                goo.Mushrooms = false;
            });

            Assert.PropertyChanged(goo, "SpecialInstructions", () =>
            {
                goo.Mushrooms = true;
            });
        }

        /// <summary>
        /// tests that Broccoli property is notified when changed
        /// </summary>
        [Fact]
        public void ChangingBroccoliNotifiesBroccoliProperty()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();

            Assert.PropertyChanged(goo, "Broccoli", () =>
            {
                goo.Broccoli = false;
            });

            Assert.PropertyChanged(goo, "Broccoli", () =>
            {
                goo.Broccoli = true;
            });
        }

        /// <summary>
        /// tests that SpecialInstructions property is notified when Broccoli is changed
        /// </summary>
        [Fact]
        public void ChangingBroccoliNotifiesSpecialInstructionsProperty()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();

            Assert.PropertyChanged(goo, "SpecialInstructions", () =>
            {
                goo.Broccoli = false;
            });

            Assert.PropertyChanged(goo, "SpecialInstructions", () =>
            {
                goo.Broccoli = true;
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