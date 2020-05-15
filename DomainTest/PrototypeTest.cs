using Domain.Prototype;
using NUnit.Framework;

namespace DomainTest
{
    public class PrototypeTest
    {
        [Test]
        public void SoldierPrototypeTest()
        {
            var adminPrototype = new ToyPrototype();
            var toy = adminPrototype.Prototype("LowSoldierRed");
            
            Assert.AreEqual(toy.Color, "Red");
        }
    }
}