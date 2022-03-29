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

     class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => PrintTeacherDetails(),
                () => PrintStudentdetails()
            );
            Console.ReadLine();
        }
        private static void PrintTeacherDetails()
        {
            Singleton fromTeacher = Singleton.GetInstance;
            fromTeacher.PrintDetails("From Teacher");
        }
        private static void PrintStudentdetails()
        {
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");
        }
    }
}
