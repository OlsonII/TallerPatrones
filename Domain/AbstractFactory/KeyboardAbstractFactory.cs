namespace Domain.AbstractFactory
{
    public abstract class KeyboardAbstractFactory
    {
        public abstract Keyboard CreateKeyboard();

        public abstract Color CreateColor();
    }
}