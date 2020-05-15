using Domain.AbstractFactory;
using NUnit.Framework;

namespace DomainTest
{
    public class AbstractFactoryTest
    {

        [Test]
        public void BuildKeyboardRgb()
        {
            var keyboard = new FactoryKeyboardMechanicRgb();
            var build = new BuildKeyboard(keyboard);
            Assert.AreEqual(build.Keyboard.Description, "Keyboard Mechanic");
        }

    }
}