using Domain.Composite;
using NUnit.Framework;

namespace DomainTest
{
    public class CompositeTest
    {
        [Test]
        public void CompositeCartTest()
        {
            var car = new Car();
            
            var doorOne = new door();
            var doorTwo = new door();
            
            var wheelOne = new Wheel();
            var wheelTwo = new Wheel();
            var wheelThree = new Wheel();
            var wheelFour = new Wheel();

            car.Add(doorOne);
            car.Add(doorTwo);
            car.Add(wheelOne);
            car.Add(wheelTwo);
            car.Add(wheelThree);
            car.Add(wheelFour);
            
            Assert.AreEqual(car.GetChildrensCount(), 6);
        }
    }
}