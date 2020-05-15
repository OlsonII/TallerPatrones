using System.Runtime.InteropServices;
using Domain.Singleton;
using NUnit.Framework;

namespace DomainTest
{
    public class Singleton
    {
        [Test]
        public void CarSingletonTest()
        {
            var car = Car.GetInstance();
            car.Model = "Ford 75";
            
            Assert.AreEqual(car.GetModel(), "Ford 75");
        }
    }
}