using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Design_Patterns.IteratorDesignPattern
{
    public class ConcreteCollection : AbstractCollection
    {
        private List< Employee> listEmployees = new List< Employee>();

        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }

        public int Count
        {
            get
            {
                return this.listEmployees.Count;
            }
        }

        public void AddEmployee(Employee employee)
        {
            this.listEmployees.Add(employee);
        }

        public Employee GetEmployee(int indexPosition)
        {
            return this.listEmployees[indexPosition];
        }
    }
}
