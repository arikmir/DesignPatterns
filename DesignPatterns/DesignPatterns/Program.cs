using System;
using DesignPatterns.Creational_Design_Patterns.FactoryDesignPattern;

namespace DesignPatterns
{
    using DesignPatterns.Creational_Design_Patterns.AbstractFactoryDesignPattern;
    using DesignPatterns.Creational_Design_Patterns.FactoryMethodDesignPattern;

    internal class Program
    {
        static void Main(string[] args)
        {
            IAnimal animal = null;
            AnimalFactory animalFactory = null;
            string speakSound = null;

            // Create the Sea Factory object by passing the factory type as Sea
            animalFactory = AnimalFactory.CreateAnimalFactory("Sea");
            Console.WriteLine("Animal Factory Type:" + animalFactory.GetType().Name);
            Console.WriteLine();

            // Get Octopus Animal object by passing the animal type as Octopus
            animal = animalFactory.GetAnimal("Octupus");
            Console.WriteLine("Animal type: "+ animal.GetType().Name);
            speakSound = animal.Speak();
            Console.WriteLine(animal.GetType().Name + " Speak : " + speakSound);
            Console.WriteLine();
            Console.WriteLine("--------------------------");
            // Create Land Factory object by passing the factory type as Land
            animalFactory = AnimalFactory.CreateAnimalFactory("Land");
            Console.WriteLine("Animal Factory type : " + animalFactory.GetType().Name);
            Console.WriteLine();
            // Get Lion Animal object by passing the animal type as Lion
            animal = animalFactory.GetAnimal("Dog");
            Console.WriteLine("Animal Type : " + animal.GetType().Name);
            speakSound = animal.Speak();
            Console.WriteLine(animal.GetType().Name + " Speak : " + speakSound);
            Console.WriteLine();
            // Get Cat Animal object by passing the animal type as Cat
            animal = animalFactory.GetAnimal("Cat");
            Console.WriteLine("Animal Type : " + animal.GetType().Name);
            speakSound = animal.Speak();
            Console.WriteLine(animal.GetType().Name + " Speak : " + speakSound);
            Console.Read();
        }
    }
}
