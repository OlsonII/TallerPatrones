using Domain.Bridge;
using NUnit.Framework;

namespace DomainTest
{
    public class BridgeTest
    {
        [Test]
        public void FabricationNewCarTest()
        {
            var newCar = new NewCar();
            var response = newCar.Fabricate(new FastFabrication());
            Assert.AreEqual(response, "Car Fabricated in 5");
        }
    }
}