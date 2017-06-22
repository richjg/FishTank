using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishTank.Tests
{
    [TestFixture]
    public class FishTests
    {
        #region GoldFish

        [Test]
        public void GoldFish_Should_ImplementIFish()
        {
            //Arrange
            //Act
            var fish = new GoldFish() as IFish;

            //Assert
            Assert.That(fish, Is.Not.Null);
        }

        [Test]
        public void FoodRequired_ForGoldFish_ShouldBe0Point1()
        {
            //Arrange
            var fish = new GoldFish();
            
            //Act
            var foodRequired = fish.FoodRequired;

            //Assert
            Assert.That(foodRequired, Is.EqualTo(0.1));
        }

        [Test]
        public void Name_ForGoldFish_CanBeSet()
        {
            //Arrange
            var fish = new GoldFish();

            //Act
            fish.Name = "gold";

            //Assert
            Assert.That(fish.Name, Is.EqualTo("gold"));
        }

        #endregion

        #region AngelFish

        [Test]
        public void AngelFish_Should_ImplementIFish()
        {
            //Arrange
            //Act
            var fish = new AngelFish() as IFish;

            //Assert
            Assert.That(fish, Is.Not.Null);
        }

        [Test]
        public void FoodRequired_ForAngelFish_ShouldBe0Point2()
        {
            //Arrange
            var fish = new AngelFish();

            //Act
            var foodRequired = fish.FoodRequired;

            //Assert
            Assert.That(foodRequired, Is.EqualTo(0.2));
        }

        [Test]
        public void Name_ForAngelFish_CanBeSet()
        {
            //Arrange
            var fish = new AngelFish();

            //Act
            fish.Name = "angel";

            //Assert
            Assert.That(fish.Name, Is.EqualTo("angel"));
        }

        #endregion

        #region BabelFish

        [Test]
        public void BabelFish_Should_ImplementIFish()
        {
            //Arrange
            //Act
            var fish = new BabelFish() as IFish;

            //Assert
            Assert.That(fish, Is.Not.Null);
        }

        [Test]
        public void FoodRequired_ForBabelFish_ShouldBe0Point2()
        {
            //Arrange
            var fish = new BabelFish();

            //Act
            var foodRequired = fish.FoodRequired;

            //Assert
            Assert.That(foodRequired, Is.EqualTo(0.3));
        }

        [Test]
        public void Name_ForBabelFish_CanBeSet()
        {
            //Arrange
            var fish = new BabelFish();

            //Act
            fish.Name = "babel";

            //Assert
            Assert.That(fish.Name, Is.EqualTo("babel"));
        }

        #endregion
    }
}
