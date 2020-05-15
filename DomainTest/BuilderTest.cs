using Domain.Builder;
using NUnit.Framework;

namespace DomainTest
{
    public class BuilderTest
    {
        [Test]
        public void PcBuilderTest()
        {
            var pcDirector = new PcDirector(new PcMasterRazeBuilder());
            pcDirector.BuildPc();
            var pc = pcDirector.GetPc();
            Assert.AreEqual(pc.Ram.Capacity, 32);
        }
    }
}