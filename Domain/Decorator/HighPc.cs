namespace Domain.Decorator
{
    public class HighPc : Pc
    {
        public override int GetPrice()
        {
            return 700;
        }
    }
}