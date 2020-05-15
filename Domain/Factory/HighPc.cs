namespace Domain.Factory
{
    public class HighPc : Pc
    {
        public string Description()
        {
            return "High Pc";
        }
        
        public override int GetPrice()
        {
            return 700;
        }
    }
}