using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_Design_Patterns.AdapterDesignPattern
{
    public class ThirdPartyBillingSystem
    {
        public void ProcessSalary(List<Employee> employeeList)
        {
            foreach (var employee in employeeList)
            {
                Console.WriteLine("Rs." + employee.Salary + " Salary Credited to " + employee.Name + " Account");
            }
        }
    }
}
