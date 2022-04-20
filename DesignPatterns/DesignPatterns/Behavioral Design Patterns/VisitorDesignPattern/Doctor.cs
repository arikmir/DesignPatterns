using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Design_Patterns.VisitorDesignPattern
{
    public class Doctor : IVisitor
    {
        public string DoctorName { get; set; }

        public Doctor(string doctorName)
        {
            DoctorName = doctorName;
        }
        public void Visit(IElement element)
        {
            Kid kid  = (Kid)element;
            Console.WriteLine("Doctor: " + this.DoctorName + " did the health checkup of the child: " + kid.KidName);
        }
    }
}
