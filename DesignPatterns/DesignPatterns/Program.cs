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
using DesignPatterns.Structural_Design_Patterns.BridgeDesignPattern;
using DesignPatterns.Structural_Design_Patterns.BridgeRealTimeExample;
using DesignPatterns.Structural_Design_Patterns.DecoratorDesignPattern;
using DesignPatterns.Structural_Design_Patterns.CompositeDesignPattern;
using DesignPatterns.Structural_Design_Patterns.ProxyDesignPattern;
using Employee = DesignPatterns.Structural_Design_Patterns.ProxyDesignPattern.Employee;
using DesignPatterns.Structural_Design_Patterns.VirtualProxyDesignPattern;
using DesignPatterns.Structural_Design_Patterns.FlyweightDesignPattern;
using DesignPatterns.Behavioral_Design_Patterns.IteratorDesignPattern;
using DesignPatterns.Behavioral_Design_Patterns.ObserverDesignPattern;

namespace DesignPatterns
{
    

    class Program
    {
        static void Main(string[] args)
        {
            //Create a Product with Out Of Stock Status
            Subject RedMI = new Subject("Red MI Mobile", 10000, "Out Of Stock");

            //User Anurag will be created and user1 object will be registered to the subject
            Observer user1 = new Observer("Anurag", RedMI);
            //User Pranaya will be created and user1 object will be registered to the subject
            Observer user2 = new Observer("Pranaya", RedMI);
            //User Priyanka will be created and user3 object will be registered to the subject
            Observer user3 = new Observer("Priyanka", RedMI);

            Console.WriteLine("Red MI Mobile current state : " + RedMI.GetAvailibility());
            Console.WriteLine();

            // Now product is available
            RedMI.SetAvailibility("Available");
            Console.Read();
        }

    }
}
