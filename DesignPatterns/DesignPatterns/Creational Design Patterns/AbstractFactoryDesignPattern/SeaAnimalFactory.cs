using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Design_Patterns.AbstractFactoryDesignPattern
{
    internal class SeaAnimalFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(string animalType)
        {
            if (animalType.Equals("Shark"))
            {
                return new Shark();
            }
            else if (animalType.Equals("Octupus"))
            {
                return new Octupus();
            }
            else
                return null;
        }
    }
}
