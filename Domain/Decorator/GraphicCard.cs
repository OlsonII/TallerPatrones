namespace Domain.Decorator
{
    public class GraphicCard : PcDecorator
    {
        public GraphicCard(IVendible vendible) : base(vendible)
        {
        }

        public override string GetDescription()
        {
            return "whit graphic card";
        }

        public override int GetPrice()
        {
            return Vendible.GetPrice() + 300;
        }
    }
}