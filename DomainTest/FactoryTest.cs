using Domain.Factory;
using NUnit.Framework;

namespace DomainTest
{
    public class FactoryTest
    {
        [Test]
        public void PcFactoryTest()
        {
            var factory = new PcFactory();
            var pc = factory.CreatePc(100);
            
            Assert.AreEqual(pc.GetType(), typeof(LowPc));
        }
    }
}