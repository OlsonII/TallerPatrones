namespace Domain.Singleton
{
    public class Car
    {
        private static Car _instance;
        public string model { get; set; }

        public Car()
        {
        }

        public static Car GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Car();
            }

            return _instance;
        }

        public string GetModel()
        {
            return model;
        }

    }
}