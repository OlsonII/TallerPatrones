namespace Domain.Decorator
{
    public abstract class Pc : IVendible
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public abstract int GetPrice();
    }
}