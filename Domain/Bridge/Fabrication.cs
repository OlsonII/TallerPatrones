

namespace Domain.Bridge
{
    public abstract class Fabrication
    {
        protected int Time { get; set; }

        public string Fabricate()
        {
            return $"Car Fabricated in {Time}";
        }
    }
}