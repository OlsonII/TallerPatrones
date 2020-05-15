
namespace Domain.Bridge
{
    public class NewCar : Car
    {
        public string Fabricate(Fabrication fabrication)
        {
            return fabrication.Fabricate();
        }
    }
}