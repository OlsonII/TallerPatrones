namespace Domain.Builder
{
    public abstract class PcBuilder
    {
        protected Pc Pc { get; set; }

        public void CreatePc()
        {
            Pc = new Pc();
        }

        public abstract void BuildRam();
        public abstract void BuildGraphicCard();
        public abstract void BuildCore();

        public Pc GetPc()
        {
            return Pc;
        }
    }
}