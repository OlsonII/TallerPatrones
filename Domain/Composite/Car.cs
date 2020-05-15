using System.Collections.Generic;

namespace Domain.Composite
{
    public class Car : IComponent
    {
        List<IComponent> Childrens;

        public Car()
        {
            Childrens = new List<IComponent>();
        }

        public void Add(IComponent component)
        {
            Childrens.Add(component);
        }

        public string Operation()
        {
            return "Operacion exitosa";
        }
    }
}