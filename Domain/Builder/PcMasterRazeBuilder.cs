namespace Domain.Builder
{
    public class PcMasterRazeBuilder : PcBuilder
    {
        public override void BuildRam()
        {
            Pc.Ram = new Ram("DDR4", 32);
        }

        public override void BuildGraphicCard()
        {
            Pc.GraphicCard = new GraphicCard("RX 2600", 8);
        }

        public override void BuildCore()
        {
            Pc.Core = new Core("R7 3900", 8);
        }
    }
}