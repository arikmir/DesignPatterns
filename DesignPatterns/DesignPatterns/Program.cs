using System;
using DesignPatterns.Creational_Design_Patterns.FactoryDesignPattern;
using DesignPatterns.Creational_Design_Patterns.AbstractFactoryDesignPattern;
using DesignPatterns.Creational_Design_Patterns.BuilderDesignPattern;
using DesignPatterns.Creational_Design_Patterns.FactoryMethodDesignPattern;

namespace DesignPatterns
{
    using System.Threading.Tasks;

    using DesignPatterns.Creational_Design_Patterns.BuilderDesignPatternCoffee;
    using DesignPatterns.Creational_Design_Patterns.FluidInterfaceDesign_Pattern;
    using DesignPatterns.Creational_Design_Patterns.SingletonDesignPattern;
    using DesignPatterns.Structural_Design_Patterns.AdapterDesignPattern;

    class Program
    {
        static void Main(string[] args)
        {
            string[,] employeesArray = new string[5, 4]
                                           {
                                               {"101","John","SE","10000"},
                                               {"102","Smith","SE","20000"},
                                               {"103","Dev","SSE","30000"},
                                               {"104","Pam","SE","40000"},
                                               {"105","Sara","SSE","50000"}
                                           };

            ITarget target = new EmployeeAdapter();
            Console.WriteLine("HR system passes employee string array to Adapter\n");
            target.ProcessCompanySalary(employeesArray);
            Console.Read();
        }
       
    }
}
