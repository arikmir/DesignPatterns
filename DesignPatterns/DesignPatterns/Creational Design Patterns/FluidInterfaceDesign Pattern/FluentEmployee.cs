using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Design_Patterns.FluidInterfaceDesign_Pattern
{
    // https://dotnettutorials.net/lesson/fluent-interface-design-pattern/
    public class FluentEmployee
    {
        private Employee employee = new Employee();

        public FluentEmployee EmployeeName(string FullName)
        {
            employee.FullName = FullName;
            return this;
        }

        public FluentEmployee BornDate(string DateOfBirth)
        {
            this.employee.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            return this;
        }
        public FluentEmployee WorkingOn(string Department)
        {
            employee.Department = Department;
            return this;
        }
        public FluentEmployee StaysAt(string Address)
        {
            employee.Address = Address;
            return this;
        }
    }
}
