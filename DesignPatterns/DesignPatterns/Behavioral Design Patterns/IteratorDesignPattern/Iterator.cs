using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Design_Patterns.IteratorDesignPattern
{
    public class Iterator : IIterator
    {
        private ConcreteCollection _collection;
        private int current = 0;

        private int step = 1;

        public Iterator(ConcreteCollection collection)
        {
            this._collection = collection;
        }

        public Employee First()
        {
            this.current = 0;
            return this._collection.GetEmployee(this.current);
        }

        public Employee Next()
        {
            this.current += this.step;
            if (!IsCompleted)
            {
                return this._collection.GetEmployee(this.current);
            }

            return null;
        }

        public bool IsCompleted
        {
            get
            {
                return this.current >= this._collection.Count;
            }
        }
    }
}
