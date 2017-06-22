using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishTank.Tests
{
    [TestFixture]
    public class SerializationTests
    {
        [Test]
        public void Serialize_Returns_EmptyTankNodeWhenNoFish()
        {
            //Arrange
            var tank = new Tank();
            var serializer = new XmlTankSerializer();

            //Act
            var result = serializer.Serialize(tank);

            //Assert
            Assert.That(result, Is.EqualTo("<FishTank />"));
        }

        [Test]
        public void Serialize_Returns_FishInTheTank()
        {
            //Arrange
            var tank = new Tank().Add(new GoldFish { Name = "gold" }).Add(new AngelFish() { Name = "angel" });
            var serializer = new XmlTankSerializer();

            //Act
            var result = serializer.Serialize(tank);

            //Assert
            Assert.That(result, Is.EqualTo("<FishTank><Fish type=\"FishTank.GoldFish\"><Name>gold</Name></Fish><Fish type=\"FishTank.AngelFish\"><Name>angel</Name></Fish></FishTank>"));
        }
    }
}
