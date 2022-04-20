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
using DesignPatterns.Behavioral_Design_Patterns.ChainOfResponsibility;
using DesignPatterns.Behavioral_Design_Patterns.RTChainOfResponsibility;
using DesignPatterns.Behavioral_Design_Patterns.StateDesignPattern;
using DesignPatterns.Behavioral_Design_Patterns.RealTimeStateDesignPattern;
using DesignPatterns.Behavioral_Design_Patterns.TemplateDesignPattern;
using DesignPatterns.Behavioral_Design_Patterns.VisitorDesignPattern;

namespace DesignPatterns
{
    using DesignPatterns.Behavioral_Design_Patterns.StrategyDesignPattern;

    class Program
    {
        static void Main(string[] args)
        {
            CompressionContext zipContext = new CompressionContext(new ZipCompression());
            zipContext.CreateArchive("file111");
            CompressionContext rarContext = new CompressionContext(new RarCompression());
            rarContext.CreateArchive("file2222");
        }
    }
}
