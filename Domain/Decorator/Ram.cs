namespace Domain.Decorator
{
    public class Ram : PcDecorator
    {
        public Ram(IVendible vendible) : base(vendible)
        {
        }

        public override string GetDescription()
        {
            return "With more ram";
        }

        public override int GetPrice()
        {
            return Vendible.GetPrice() + 200;
        }
    }
}