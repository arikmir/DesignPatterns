using System;
using System.Threading.Tasks;
using System.Collections.Generic;

using DesignPatterns.Creational_Design_Patterns.FactoryDesignPattern;
using DesignPatterns.Creational_Design_Patterns.AbstractFactoryDesignPattern;
using DesignPatterns.Creational_Design_Patterns.BuilderDesignPattern;
using DesignPatterns.Creational_Design_Patterns.FactoryMethodDesignPattern;
using DesignPatterns.Creational_Design_Patterns.BuilderDesignPatternCoffee;
using DesignPatterns.Creational_Design_Patterns.FluidInterfaceDesign_Pattern;
using DesignPatterns.Creational_Design_Patterns.SingletonDesignPattern;
using DesignPatterns.Structural_Design_Patterns.AdapterDesignPattern;
using DesignPatterns.Structural_Design_Patterns.AdapterRealTimeExample;
using DesignPatterns.Structural_Design_Patterns.BridgeRealTimeExample;
using DesignPatterns.Structural_Design_Patterns.DecoratorDesignPattern;
using DesignPatterns.Structural_Design_Patterns.CompositeDesignPattern;
using DesignPatterns.Structural_Design_Patterns.ProxyDesignPattern;
using Employee = DesignPatterns.Structural_Design_Patterns.ProxyDesignPattern.Employee;
using DesignPatterns.Structural_Design_Patterns.VirtualProxyDesignPattern;
using DesignPatterns.Structural_Design_Patterns.FlyweightDesignPattern;
using DesignPatterns.Behavioral_Design_Patterns.IteratorDesignPattern;
using DesignPatterns.Behavioral_Design_Patterns.ObserverDesignPattern;
using DesignPatterns.Behavioral_Design_Patterns.ChainOfResponsibility;
using DesignPatterns.Behavioral_Design_Patterns.RTChainOfResponsibility;
using DesignPatterns.Behavioral_Design_Patterns.StateDesignPattern;
using DesignPatterns.Behavioral_Design_Patterns.RealTimeStateDesignPattern;
using DesignPatterns.Behavioral_Design_Patterns.TemplateDesignPattern;
using DesignPatterns.Behavioral_Design_Patterns.VisitorDesignPattern;
using DesignPatterns.Behavioral_Design_Patterns.InterpreterDesignPattern;
using DesignPatterns.Behavioral_Design_Patterns.StrategyDesignPattern;
using DesignPatterns.Behavioral_Design_Patterns.MediatorDesignPattern;
using DesignPatterns.Behavioral_Design_Patterns.MementoDesignPattern;


namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator();
            originator.ledTV = new LEDTV("42 inch", "60000Rs", false);

            Caretaker caretaker = new Caretaker();
            caretaker.AddMemento(originator.CreateMemento());

            originator.ledTV = new LEDTV("46 inch", "80000Rs", true);
            caretaker.AddMemento(originator.CreateMemento());
            originator.ledTV = new LEDTV("50 inch", "100000Rs", true);

            Console.WriteLine("\nOrignator current state : " + originator.GetDetails());

            Console.WriteLine("\nOriginator restoring to 42 inch LED TV");
            originator.ledTV = caretaker.GetMemento(0).ledTV;
            Console.WriteLine("\nOrignator current state : " + originator.GetDetails());
            Console.ReadKey();
        }
    }
}
