/*
 * Author: Zachery Brunner
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// testing class for Smokehouse skeleton
    /// </summary>
    public class SmokehouseSkeletonTests
    {
        /// <summary>
        /// ensures this class inherits from the IOrderItem interface
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<IOrderItem>(ss);
        }

        /// <summary>
        /// ensures this class inherits from the base Entree class
        /// </summary>
        [Fact]
        public void ShouldBeAnEntree()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<Entree>(ss);
        }

        /// <summary>
        /// Tests that the Sausage is true by default
        /// </summary>
        [Fact]
        public void ShouldInlcudeSausageByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.SausageLink);
        }

        /// <summary>
        /// Tests that the HashBrowns is true by default
        /// </summary>
        [Fact]
        public void ShouldInlcudeEggByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.Egg);
        }

        /// <summary>
        /// Tests that the Pancake is true by default
        /// </summary>
        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.HashBrowns);
        }

        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.Pancake);
        }

        /// <summary>
        /// Tests that Sausage can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.SausageLink = false;
            Assert.False(ss.SausageLink);
            ss.SausageLink = true;
            Assert.True(ss.SausageLink);
        }

        /// <summary>
        /// Tests that Egg can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.Egg = false;
            Assert.False(ss.Egg);
            ss.Egg = true;
            Assert.True(ss.Egg);
        }

        /// <summary>
        /// Tests that HashBrowns can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.HashBrowns = false;
            Assert.False(ss.HashBrowns);
            ss.HashBrowns = true;
            Assert.True(ss.HashBrowns);
        }

        /// <summary>
        /// Tests that Pancake can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.Pancake = false;
            Assert.False(ss.Pancake);
            ss.Pancake = true;
            Assert.True(ss.Pancake);
        }

        /// <summary>
        /// tests that price of the combo matches the correct price
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.Equal(5.62, ss.Price);
        }

        /// <summary>
        /// tests that calories of the combo matches the correct Calories
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.Equal((uint)602, ss.Calories);
        }

        /// <summary>
        /// Tests that the special instructions are met
        /// </summary>
        /// <param name="includeSausage">vaue of Sausage</param>
        /// <param name="includeEgg">value of Egg</param>
        /// <param name="includeHashbrowns">value of HashBrowns</param>
        /// <param name="includePancake">value of Pancake</param>        
        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.SausageLink = includeSausage;
            ss.Egg = includeEgg;
            ss.HashBrowns = includeHashbrowns;
            ss.Pancake = includePancake;

            if (includeSausage)
            {
                Assert.Empty(ss.SpecialInstructions);
            }
            else if (!includeSausage)
            {
                Assert.Contains("Hold sausage", ss.SpecialInstructions);
                Assert.Contains("Hold eggs", ss.SpecialInstructions);
                Assert.Contains("Hold hash browns", ss.SpecialInstructions);
                Assert.Contains("Hold pancakes", ss.SpecialInstructions);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.Equal("Smokehouse Skeleton", ss.ToString());
        }


        /// <summary>
        /// tests that Pancake property is notified when changed
        /// </summary>
        [Fact]
        public void ChangingPancakeNotifiesPancakeProperty()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();

            Assert.PropertyChanged(ss, "Pancake", () =>
            {
                ss.Pancake = false;
            });

            Assert.PropertyChanged(ss, "Pancake", () =>
            {
                ss.Pancake = true;
            });
        }

        /// <summary>
        /// tests that SpecialInstructions property is notified when Pancake is changed
        /// </summary>
        [Fact]
        public void ChangingPancakeNotifiesSpecialInstructionsProperty()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();

            Assert.PropertyChanged(ss, "SpecialInstructions", () =>
            {
                ss.Pancake = false;
            });

            Assert.PropertyChanged(ss, "SpecialInstructions", () =>
            {
                ss.Pancake = true;
            });
        }

        /// <summary>
        /// tests that HashBrowns property is notified when changed
        /// </summary>
        [Fact]
        public void ChangingHashBrownsNotifiesHashBrownsProperty()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();

            Assert.PropertyChanged(ss, "HashBrowns", () =>
            {
                ss.HashBrowns = false;
            });

            Assert.PropertyChanged(ss, "HashBrowns", () =>
            {
                ss.HashBrowns = true;
            });
        }

        /// <summary>
        /// tests that SpecialInstructions property is notified when HashBrowns is changed
        /// </summary>
        [Fact]
        public void ChangingHashBrownsNotifiesSpecialInstructionsProperty()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();

            Assert.PropertyChanged(ss, "SpecialInstructions", () =>
            {
                ss.HashBrowns = false;
            });

            Assert.PropertyChanged(ss, "SpecialInstructions", () =>
            {
                ss.HashBrowns = true;
            });
        }

        /// <summary>
        /// tests that SausageLink property is notified when changed
        /// </summary>
        [Fact]
        public void ChangingSausageLinkNotifiesSausageLinkProperty()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();

            Assert.PropertyChanged(ss, "SausageLink", () =>
            {
                ss.SausageLink = false;
            });

            Assert.PropertyChanged(ss, "SausageLink", () =>
            {
                ss.SausageLink = true;
            });
        }

        /// <summary>
        /// tests that SpecialInstructions property is notified when SausageLink is changed
        /// </summary>
        [Fact]
        public void ChangingSausageLinkNotifiesSpecialInstructionsProperty()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();

            Assert.PropertyChanged(ss, "SpecialInstructions", () =>
            {
                ss.SausageLink = false;
            });

            Assert.PropertyChanged(ss, "SpecialInstructions", () =>
            {
                ss.SausageLink = true;
            });
        }

        /// <summary>
        /// tests that Egg property is notified when changed
        /// </summary>
        [Fact]
        public void ChangingEggNotifiesEggProperty()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();

            Assert.PropertyChanged(ss, "Egg", () =>
            {
                ss.Egg = false;
            });

            Assert.PropertyChanged(ss, "Egg", () =>
            {
                ss.Egg = true;
            });
        }

        /// <summary>
        /// tests that SpecialInstructions property is notified when Egg is changed
        /// </summary>
        [Fact]
        public void ChangingEggNotifiesSpecialInstructionsProperty()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();

            Assert.PropertyChanged(ss, "SpecialInstructions", () =>
            {
                ss.Egg = false;
            });

            Assert.PropertyChanged(ss, "SpecialInstructions", () =>
            {
                ss.Egg = true;
            });
        }


        /// <summary>
        /// tests that this class inherits from the INotifyPropertyChanged interface
        /// </summary>
        [Fact]
        public void ShouldBeAnINotifyPropertyChanged()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(ss);
        }
    }
}
