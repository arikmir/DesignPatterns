using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Design_Patterns.VisitorDesignPattern
{
    public interface IElement
    {
        void Accept(IVisitor visitor); 
    }
}
