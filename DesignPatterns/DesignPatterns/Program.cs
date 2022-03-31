using System;
using System.Threading.Tasks;

using DesignPatterns.Creational_Design_Patterns.FactoryDesignPattern;
using DesignPatterns.Creational_Design_Patterns.AbstractFactoryDesignPattern;
using DesignPatterns.Creational_Design_Patterns.BuilderDesignPattern;
using DesignPatterns.Creational_Design_Patterns.FactoryMethodDesignPattern;
using DesignPatterns.Creational_Design_Patterns.BuilderDesignPatternCoffee;
using DesignPatterns.Creational_Design_Patterns.FluidInterfaceDesign_Pattern;
using DesignPatterns.Creational_Design_Patterns.SingletonDesignPattern;
using DesignPatterns.Structural_Design_Patterns.AdapterDesignPattern;
using DesignPatterns.Structural_Design_Patterns.AdapterRealTimeExample;

namespace DesignPatterns
{
    using DesignPatterns.Structural_Design_Patterns.DecoratorDesignPattern;

    class Program
    {
        static void Main(string[] args)
        {
            ICar bmwDiesel = new BMW();
            bmwDiesel.ManufactureCar();
            Console.WriteLine(bmwDiesel + "\n");

            DieselCarDecorator carWithDiesel = new DieselCarDecorator(bmwDiesel);
            carWithDiesel.ManufactureCar();
            Console.WriteLine();

            ICar bmwPetrol = new BMW();
            bmwPetrol.ManufactureCar();
            Console.WriteLine(bmwPetrol + "\n");

            PetrolCarDecorator carWithPetrol = new PetrolCarDecorator(bmwPetrol);
            carWithPetrol.ManufactureCar();
            Console.WriteLine();
        }
       
    }
}
