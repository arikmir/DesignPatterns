using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Design_Patterns.RTChainOfResponsibility
{
    public class TeamLeader : Employee
    {
        private int MaxLeave = 10;
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
            Console.WriteLine("Team Leader approved " + numberofDaysLeave + " days " + "Leave for the employee : "
                              + employeeName);
        }
    }
}
