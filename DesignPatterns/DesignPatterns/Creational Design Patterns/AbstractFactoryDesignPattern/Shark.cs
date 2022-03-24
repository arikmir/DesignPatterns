#region All Rights Reserved

// DesignPatterns
// Canaria Technologies 2022

#endregion

namespace DesignPatterns.Creational_Design_Patterns.AbstractFactoryDesignPattern
{
    public class Shark : IAnimal
    {
        public string Speak()
        {
            return "Cannot Speak";
        }
    }
}