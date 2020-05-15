using System.Diagnostics;

namespace Domain.Factory
{
    public class PcFactory : IPcFactoryMethod
    {
        public Pc CreatePc(int price)
        {
            switch(price)
            {
                case 100:
                    return new LowPc();
                case 700:
                    return new HighPc();
            }

            return null;
        }
    }
}