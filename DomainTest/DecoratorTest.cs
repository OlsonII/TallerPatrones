using Domain.Decorator;
using NUnit.Framework;

namespace DomainTest
{
    public class DecoratorTest
    {
        [Test]
        public void PcDecoratorTest()
        {
            IVendible pc = new LowPc();
            pc = new Ram(pc);
            pc = new GraphicCard(pc);
            
            Assert.AreEqual(pc.GetPrice(), 600);
        }
    }
}