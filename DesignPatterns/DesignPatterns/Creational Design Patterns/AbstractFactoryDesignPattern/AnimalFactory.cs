using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://dotnettutorials.net/lesson/abstract-factory-design-pattern-csharp/

namespace DesignPatterns.Creational_Design_Patterns.AbstractFactoryDesignPattern
{
    public abstract class AnimalFactory
    {
        public abstract IAnimal GetAnimal(string animalType);

        public static AnimalFactory CreateAnimalFactory(string factoryType)
        {
            if (factoryType.Equals("Sea"))
                return new SeaAnimalFactory();
            else
                return new LandAnimalFactory();
        }
    }
}
