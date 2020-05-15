namespace Domain.Factory
{
    public class LowPc : Pc
    {
        public string Description()
        {
            return "Low Pc";
        }
        
        public override int GetPrice()
        {
            return 100;
        }
    }
}