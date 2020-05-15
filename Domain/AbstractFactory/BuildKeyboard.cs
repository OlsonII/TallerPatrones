namespace Domain.AbstractFactory
{
    public class BuildKeyboard
    {
        public Color Color { get; set; }
        public Keyboard Keyboard { get; set; }
        public BuildKeyboard(KeyboardAbstractFactory factory)
        {
            Color = factory.CreateColor();
            Keyboard = factory.CreateKeyboard();
        }
    }
}