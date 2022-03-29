using System;
using DesignPatterns.Creational_Design_Patterns.FactoryDesignPattern;
using DesignPatterns.Creational_Design_Patterns.AbstractFactoryDesignPattern;
using DesignPatterns.Creational_Design_Patterns.BuilderDesignPattern;
using DesignPatterns.Creational_Design_Patterns.FactoryMethodDesignPattern;

namespace DesignPatterns
{
    using DesignPatterns.Creational_Design_Patterns.BuilderDesignPatternCoffee;
    using DesignPatterns.Creational_Design_Patterns.FluidInterfaceDesign_Pattern;
    using DesignPatterns.Creational_Design_Patterns.SingletonDesignPattern;

    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton fromTeacher = Singleton.GetInstance;
            fromTeacher.PrintDetails("From Teacher");
            Singleton fromStundet = Singleton.GetInstance;
            fromStundet.PrintDetails("From Studnet");

            Console.ReadLine();
        }
    }
}
