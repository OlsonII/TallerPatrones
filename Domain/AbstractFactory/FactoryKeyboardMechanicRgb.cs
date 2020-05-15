namespace Domain.AbstractFactory
{
    public class FactoryKeyboardMechanicRgb : KeyboardAbstractFactory
    {
        public override Color CreateColor()
        {
            return new Rgb();
        }

        public override Keyboard CreateKeyboard()
        {
            return new Mechanic("Keyboard Mechanic");
        }
    }
}