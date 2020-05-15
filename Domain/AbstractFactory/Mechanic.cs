namespace Domain.AbstractFactory
{
    public class Mechanic : Keyboard
    {
        public double Cost { get; set; }

        public Mechanic(string description)
        {
            Description = description;
        }
    }
}