using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Design_Patterns.VisitorDesignPattern
{
    public class Kid : IElement
    {
        public string KidName { get; set; }

        public Kid(string kidName)
        {
            KidName = kidName;
        }
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
