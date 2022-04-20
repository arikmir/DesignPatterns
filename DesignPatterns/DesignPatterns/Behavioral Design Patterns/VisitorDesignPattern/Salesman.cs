using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Design_Patterns.VisitorDesignPattern
{
    public class Salesman : IVisitor
    {
        public string SalesManName { get; set; }

        public Salesman(string salesManName)
        {
            SalesManName = salesManName;
        }
        public void Visit(IElement element)
        {
            Kid kid = (Kid)element;
            Console.WriteLine("Salesman: " + this.SalesManName + " gave the school bag to the child: "
                              + kid.KidName);
        }
    }
}
