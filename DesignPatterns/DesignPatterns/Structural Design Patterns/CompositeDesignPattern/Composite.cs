using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_Design_Patterns.CompositeDesignPattern
{
    //https://dotnettutorials.net/lesson/composite-design-pattern/
    public class Composite : IComponent
    {
        public string Name { get; set; }

        List<IComponent> components = new List<IComponent>();

        public Composite(string name)
        {
            Name = name;
        }

        public void AddComponent(IComponent component)
        {
            components.Add(component);
        }

        public void DisplayPrice()
        {
            Console.WriteLine(Name);
            foreach (var component in components)
            {
                component.DisplayPrice();
            }
        }
    }
}
