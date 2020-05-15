namespace Domain.Decorator
{
    public abstract class PcDecorator : IVendible
    {
        protected IVendible Vendible { get; set; }

        protected PcDecorator(IVendible vendible)
        {
            Vendible = vendible;
        }

        public abstract string GetDescription();

        public abstract int GetPrice();
    }
}