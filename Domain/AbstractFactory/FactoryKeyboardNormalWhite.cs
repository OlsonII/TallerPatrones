namespace Domain.AbstractFactory
{
    public class FactoryKeyboardNormalWhite
    {
        public Color CreateColor()
        {
            return new White();
        }

        public Keyboard CreateKeyboard()
        {
            return new Normal();
        }
    }
}