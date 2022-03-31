using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_Design_Patterns.AdapterDesignPattern
{
    //https://dotnettutorials.net/lesson/adapter-design-pattern/
    public class EmployeeAdapter : ThirdPartyBillingSystem, ITarget
    {
        //we only inherit from the adaptee(ThirdPartyBillingSystem) if its a class adapter pattern
        //following line is required if its a object adapter pattern
        //ThirdPartyBillingSystem thirdPartyBillingSystem = new ThirdPartyBillingSystem();
        public void ProcessCompanySalary(string[,] employeesArray)
        {
            string Id = null;
            string Name = null;
            string Designation = null;
            string Salary = null;

            List<Employee> employeeList = new List<Employee>();

            for (int i = 0; i < employeesArray.GetLength(0); i++)
            {
                for (int j = 0; j < employeesArray.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        Id = employeesArray[i, j];
                    }
                    else if (j == 1)
                    {
                        Name = employeesArray[i, j];
                    }
                    else if (j == 2)
                    {
                        Designation = employeesArray[i, j];
                    }
                    else
                    {
                        Salary = employeesArray[i, j];
                    }
                }

                employeeList.Add(new Employee(Convert.ToInt32(Id), Name, Designation, Convert.ToDecimal(Salary)));
            }

            Console.WriteLine("Adapter converted Array of Employee to List of Employee");
            Console.WriteLine("Then delegate to the ThirdPartyBillingSystem for processing the employee salary\n");
            ProcessSalary(employeeList);
            //thirdPartyBillingSystem.ProcessSalary(listEmployee); - replace line above for object adapter pattern
        }
    }
}
