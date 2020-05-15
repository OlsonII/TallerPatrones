namespace Domain.Builder
{
    public class MediumPcBuilder : PcBuilder
    {
        public override void BuildRam()
        {
            Pc.Ram = new Ram("DDR4", 16);
        }

        public override void BuildGraphicCard()
        {
            Pc.GraphicCard = new GraphicCard("RX 570", 4);
        }

        public override void BuildCore()
        {
            Pc.Core = new Core("R5 2600", 6);
        }
    }
}