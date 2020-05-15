namespace Domain.Adapter
{
    public class OldCar : Car, IOldCar
    {
        public string Mp3Player { get; set;  }
        public string Airbags { get; set; }
        
        public void setColor()
        {
            throw new System.NotImplementedException();
        }

        public void SetModel(string model)
        {
            Model = model;
        }

        public void SetMp3Player(string mp3)
        {
            Mp3Player = mp3;
        }

        public void SetAirbags(string airbags)
        {
            Airbags = airbags;
        }
    }
}