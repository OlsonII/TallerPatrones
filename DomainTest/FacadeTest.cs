using Domain.Facade;
using NUnit.Framework;

namespace DomainTest
{
    public class FacadeTest
    {
        [Test]
        public void WorkshopFacadeTest()
        {
            var racingCar = new RacingCar();
            var streetCar = new StreetCar();
            
            var workshop = new Workshop();
            var timeRepairingRacingCar = workshop.Repair(racingCar);
            var timeRepairingStreetCar = workshop.Repair(streetCar);
            
            Assert.AreEqual(timeRepairingRacingCar, 2);
        }
    }
}