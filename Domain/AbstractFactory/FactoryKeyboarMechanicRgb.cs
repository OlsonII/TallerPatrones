namespace Domain.AbstractFactory
{
    public class FactoryKeyboarMechanicRgb
    {
        public Color CreateColor()
        {
            return new Rgb();
        }

        public Keyboard CreateKeyboard()
        {
            return new Mechanic();
        }
    }
}