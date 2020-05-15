using System.Collections.Generic;

namespace Domain.Composite
{
    public class Wheel : IComponent
    {
        List<IComponent> Childrens;

        public Wheel()
        {
            Childrens = new List<IComponent>();
        }

        public void Add(IComponent component)
        {
            Childrens.Add(component);
        }

        public string Operation()
        {
            return "Llanta michellin R17";
        }
    }
}