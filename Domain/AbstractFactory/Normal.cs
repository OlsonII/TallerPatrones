namespace Domain.AbstractFactory
{
    public class Normal : Keyboard
    {
        public double Cost { get; set; }

        public Normal(string description)
        {
            Description = description;
        }
    }
}