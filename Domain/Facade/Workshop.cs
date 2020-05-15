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

        private int RepairStreetCar(StreetCar car)
        {
            return 1;
        }

        private int RepairRacingCar(RacingCar car)
        {
            return 2;
        }

        public int Repair(Car car)
        {
            switch (car)
            {
                case RacingCar racingCar:
                    return RepairRacingCar(racingCar);
                case StreetCar streetCar:
                    return RepairStreetCar(streetCar);
            }

            return 0;
        }
    }
}