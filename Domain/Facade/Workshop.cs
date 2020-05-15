namespace Domain.Facade
{
    public class Workshop
    {
        private ChangeColor ChangeColor;
        private RepairEngine RepairEngine;
        private ChangeOil ChangeOil;

        public Workshop()
        {
            ChangeColor = new ChangeColor();
            RepairEngine = new RepairEngine();
            ChangeOil = new ChangeOil();
        }

        public int RepairStreetCar(StreetCar car)
        {
            return 1;
        }

        public int RepairRacingCar(RacingCar car)
        {
            return 2;
        }

        public void Repair(Car car)
        {
            switch (car)
            {
                case RacingCar racingCar:
                    RepairRacingCar(racingCar);
                    break;
                case StreetCar streetCar:
                    RepairStreetCar(streetCar);
                    break;
            }
        }
    }
}