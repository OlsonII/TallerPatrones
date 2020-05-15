namespace Domain.Decorator
{
    public class LowPc : Pc
    {
        public override int GetPrice()
        {
            return 100;
        }
    }
}