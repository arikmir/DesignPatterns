using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Design_Patterns.VisitorDesignPattern
{
    public class School
    {
        private static List<IElement> kids;

        static School()
        {
            kids = new List<IElement> {new Kid("Ram"), new Kid("Sara"), new Kid("Pam")};
        }

        public void PerformOperation(IVisitor visitor)
        {
            foreach (var kid in kids)
            {
                kid.Accept(visitor);
            }
        }
    }
}
