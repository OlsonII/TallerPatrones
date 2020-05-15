namespace Domain.AbstractFactory
{
    public class BuildKeyboard
    {
        public BuildKeyboard(KeyboardAbstractFactory factory)
        {
            Color color = factory.CreateColor();
            Keyboard keyboard = factory.CreateKeyboard();
        }
    }
}