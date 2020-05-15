namespace Domain.Builder
{
    public class Ram
    {
        public string Reference { get; set; }
        public int Capacity { get; set; }

        public Ram(string reference, int capacity)
        {
            Reference = reference;
            Capacity = capacity;
        }
    }
}