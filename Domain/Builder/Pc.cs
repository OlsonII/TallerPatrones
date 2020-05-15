namespace Domain.Builder
{
    public class Pc
    {
        public Core Core { get; set; }
        public Ram Ram { get; set; }
        public GraphicCard GraphicCard { get; set; }

        public Pc()
        {
        }
    }
}