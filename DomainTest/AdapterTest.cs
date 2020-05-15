using Domain.Adapter;
using NUnit.Framework;

namespace DomainTest
{
    public class AdapterTest
    {
        [Test]
        public void OldToNewTest()
        {
            OldCar oldCar = new OldCar();
            oldCar.Model = "Ford 86";
            oldCar.Color = "Red";
            
            CarOldToNewAdapter newCar = new CarOldToNewAdapter(oldCar);
            newCar.SetModel("Ford 20");
            
            Assert.AreEqual(newCar.GetType(), typeof(CarOldToNewAdapter));
        }
    }
}