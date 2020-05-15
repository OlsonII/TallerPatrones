using System;

namespace Domain.Prototype
{
    public abstract class Toy : ICloneable
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public object Clone()
        {
            return this;
        }
    }
}