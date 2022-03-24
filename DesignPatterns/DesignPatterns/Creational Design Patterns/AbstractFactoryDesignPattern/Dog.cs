#region All Rights Reserved

// DesignPatterns
// Canaria Technologies 2022

#endregion

namespace DesignPatterns.Creational_Design_Patterns.AbstractFactoryDesignPattern
{
    public class Dog : IAnimal
    {
        public string Speak()
        {
            return "Bark bark";
        }
    }
}