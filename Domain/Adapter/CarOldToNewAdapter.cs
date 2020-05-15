namespace Domain.Adapter
{
    public class CarOldToNewAdapter : INewCar
    {
        public IOldCar OldCar { get; }

        public CarOldToNewAdapter(IOldCar oldCar)
        {
            OldCar = oldCar;
        }

        public void SetModel(string model)
        {
            OldCar.SetModel(model);
        }
    }
}