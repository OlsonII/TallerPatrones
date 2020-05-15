namespace Domain.Builder
{
    public class GraphicCard
    {
        public string Reference { get; set; }
        public int VRam { get; set; }

        public GraphicCard(string reference, int vRam)
        {
            Reference = reference;
            VRam = vRam;
        }
    }
}