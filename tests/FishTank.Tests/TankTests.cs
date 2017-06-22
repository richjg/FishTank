using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishTank.Tests
{
    [TestFixture]
    public class TankTests
    {
        [Test]
        public void Add_Adds_FishToTheTank()
        {
            //Arrange
            var tank = new Tank();
            var fish = new GoldFish { Name = "gold" };

            //Act
            tank.Add(fish);

            //Assert
            Assert.That(tank.Count, Is.EqualTo(1));
            Assert.That(tank.Fish.First(), Is.SameAs(fish));
        }

        [Test]
        public void Add_Adds_ManyFishToTheTank()
        {
            //Arrange
            var tank = new Tank();

            //Act
            tank.Add(new GoldFish { Name = "gold1" })
                .Add(new BabelFish { Name = "babel1" })
                .Add(new AngelFish { Name = "angel1" })
                .Add(new GoldFish { Name = "gold2" })
                .Add(new BabelFish { Name = "babel2" })
                .Add(new AngelFish { Name = "angel2" });

            //Assert
            Assert.That(tank.Count, Is.EqualTo(6));

            Assert.That(tank.Fish.ElementAt(0), Is.InstanceOf<GoldFish>());
            Assert.That(tank.Fish.ElementAt(0).Name, Is.EqualTo("gold1"));
            Assert.That(tank.Fish.ElementAt(1), Is.InstanceOf<BabelFish>());
            Assert.That(tank.Fish.ElementAt(1).Name, Is.EqualTo("babel1"));
            Assert.That(tank.Fish.ElementAt(2), Is.InstanceOf<AngelFish>());
            Assert.That(tank.Fish.ElementAt(2).Name, Is.EqualTo("angel1"));

            Assert.That(tank.Fish.ElementAt(3), Is.InstanceOf<GoldFish>());
            Assert.That(tank.Fish.ElementAt(3).Name, Is.EqualTo("gold2"));
            Assert.That(tank.Fish.ElementAt(4), Is.InstanceOf<BabelFish>());
            Assert.That(tank.Fish.ElementAt(4).Name, Is.EqualTo("babel2"));
            Assert.That(tank.Fish.ElementAt(5), Is.InstanceOf<AngelFish>());
            Assert.That(tank.Fish.ElementAt(5).Name, Is.EqualTo("angel2"));
        }

        [Test]
        public void Feed_Returns_ZeroWhenNoFishInTank()
        {
            //Arrange
            var tank = new Tank();
            
            //Act
            var amount = tank.Feed();

            //Assert
            Assert.That(amount, Is.Zero);
        }
        
        [Test]
        public void Feed_Returns_TheSumOfTheFishFoodRequired()
        {
            //Arrange
            var tank = new Tank();

            //Act
            tank.Add(new GoldFish { Name = "gold1" })
                .Add(new BabelFish { Name = "babel1" })
                .Add(new AngelFish { Name = "angel1" });

            //Act
            var amount = tank.Feed();

            //Assert
            Assert.That(amount, Is.EqualTo(0.6));
        }
    }
}
