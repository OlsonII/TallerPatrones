namespace Domain.Builder
{
    public class Core
    {
        public string Name { get; set; }
        public int Cores { get; set; }

        public Core(string name, int cores)
        {
            Name = name;
            Cores = cores;
        }
    }
}