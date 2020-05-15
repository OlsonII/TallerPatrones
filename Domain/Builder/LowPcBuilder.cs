namespace Domain.Builder
{
    public class LowPcBuilder : PcBuilder
    {
        public override void BuildRam()
        {
            Pc.Ram = new Ram("DDR4", 8);
        }

        public override void BuildGraphicCard()
        {
            Pc.GraphicCard = new GraphicCard("RX 560", 4);
        }

        public override void BuildCore()
        {
            Pc.Core = new Core("R3 1200", 4);
        }
    }
}