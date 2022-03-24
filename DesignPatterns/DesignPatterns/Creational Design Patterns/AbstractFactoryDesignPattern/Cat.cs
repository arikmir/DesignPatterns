using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Design_Patterns.AbstractFactoryDesignPattern
{
    public class Cat : IAnimal
    {
        public string Speak()
        {
            return "Meow Meow Meow";
        }

    }
}
