using System;
using DesignPatterns.Creational_Design_Patterns.FactoryDesignPattern;
using DesignPatterns.Creational_Design_Patterns.AbstractFactoryDesignPattern;
using DesignPatterns.Creational_Design_Patterns.BuilderDesignPattern;
using DesignPatterns.Creational_Design_Patterns.FactoryMethodDesignPattern;

namespace DesignPatterns
{
    using DesignPatterns.Creational_Design_Patterns.BuilderDesignPatternCoffee;
    using DesignPatterns.Creational_Design_Patterns.FluidInterfaceDesign_Pattern;

    internal class Program
    {
        static void Main(string[] args)
        {
            FluentEmployee employee = new FluentEmployee();

            employee.EmployeeName("Arik").BornDate("10/10/1992").WorkingOn("IT").StaysAt("Mumbai-India");

            Employee employee1 = new Employee();
            employee1.FullName = "Anurag";
            employee1.Department = "IT";

            Employee employee2 = employee1.GetClone();
            employee2.FullName = "Pranaya";
            employee2.Department = "tet";

            Console.WriteLine("Emplpyee 1: ");
            Console.WriteLine("Name: " + employee1.FullName + ", Department: " + employee1.Department);
            Console.WriteLine("Emplpyee 2: ");
            Console.WriteLine("Name: " + employee2.FullName + ", Department: " + employee2.Department);
            Console.Read();

        }
    }
}
