using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Design_Patterns.FluidInterfaceDesign_Pattern
{
   // https://dotnettutorials.net/lesson/prototype-design-pattern/
    public class Employee
    {
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Department { get; set; }
        public string Address { get; set; }

        public Employee GetClone()
        {
            return (Employee) this.MemberwiseClone();
        }
    }
}
