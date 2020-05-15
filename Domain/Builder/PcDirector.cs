namespace Domain.Builder
{
    public class PcDirector
    {
        private PcBuilder _pcBuilder;

        public PcDirector(PcBuilder pcBuilder)
        {
            _pcBuilder = pcBuilder;
        }

        public void BuildPc()
        {
            _pcBuilder.CreatePc();
            _pcBuilder.BuildCore();
            _pcBuilder.BuildRam();
            _pcBuilder.BuildGraphicCard();
        }

        public Pc GetPc()
        {
            return _pcBuilder.GetPc();
        }
    }
}