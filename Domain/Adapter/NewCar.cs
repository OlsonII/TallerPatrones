namespace Domain.Adapter
{
    public class NewCar  : Car, INewCar
    {
        public void SetModel(string model)
        {
            Model = model;
        }
    }
}