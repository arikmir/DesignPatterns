using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Design_Patterns.RTChainOfResponsibility
{
    public class ProjectLeader : Employee
    {
        private int MaxLeave = 20;
        public override void applyLeave(string employeeName, int numberofDaysLeave)
        {
            if (numberofDaysLeave >= this.MaxLeave)
            {
                ApproveLeave(employeeName, numberofDaysLeave);
            }
            else
            {
                this.supervisor.applyLeave(employeeName, numberofDaysLeave);
            }
        }
        private void ApproveLeave(string employeeName, int numberofDaysLeave)
        {
            Console.WriteLine("Project Leader approved " + numberofDaysLeave + " days " + "Leave for the employee : "
                              + employeeName);
        }
    }
}
