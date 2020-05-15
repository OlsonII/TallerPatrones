namespace Domain.Bridge
{
    public class OldCar : Car
    {
        public string Fabricate(Fabrication fabrication)
        {
            return fabrication.Fabricate();
        }
    }
}