namespace Domain.Factory
{
    public abstract class Pc
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public abstract int GetPrice();
    }
}