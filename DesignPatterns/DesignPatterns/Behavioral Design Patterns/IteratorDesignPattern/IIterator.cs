using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Behavioral_Design_Patterns.IteratorDesignPattern;

namespace DesignPatterns.Behavioral_Design_Patterns.IteratorDesignPattern
{
    using DesignPatterns.Creational_Design_Patterns.FluidInterfaceDesign_Pattern;

    public interface IIterator
    {
        Employee First();
        Employee Next();
        bool IsCompleted { get; }
    }
}
