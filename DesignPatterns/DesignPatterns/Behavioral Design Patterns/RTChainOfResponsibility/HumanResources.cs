using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Design_Patterns.RTChainOfResponsibility
{
    public class HumanResources : Employee
    {
        private int MaxLeave = 30;
        public override void applyLeave(string employeeName, int numberofDaysLeave)
        {
            if (numberofDaysLeave >= this.MaxLeave)
            {
                ApproveLeave(employeeName, numberofDaysLeave);
            }
            else
            {
                Console.WriteLine("Leave application suspended, Please contact HR");
            }
        }
        private void ApproveLeave(string employeeName, int numberofDaysLeave)
        {
            Console.WriteLine("HR approved " + numberofDaysLeave + " days " + "Leave for the employee : "
                              + employeeName);
        }
    }
}
