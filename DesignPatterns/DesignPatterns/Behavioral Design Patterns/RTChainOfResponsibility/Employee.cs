using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Design_Patterns.RTChainOfResponsibility
{
    public abstract class Employee
    {
        protected Employee supervisor;

        public void SetNextSupervisor(Employee supervisor)
        {
            this.supervisor = supervisor;
        }
        public abstract void applyLeave(string employeeName, int numberofDaysLeave);
    }
}
