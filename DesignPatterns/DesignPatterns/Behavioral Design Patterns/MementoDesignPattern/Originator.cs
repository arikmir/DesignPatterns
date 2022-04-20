using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Design_Patterns.MementoDesignPattern
{
    public class Originator
    {
        public LEDTV ledTV;

        public Memento CreateMemento()
        {
            return new Memento(ledTV);
        }

        public void SetMemento(Memento memento)
        {
            ledTV = memento.ledTV;
        }

        public string GetDetails()
        {
            return "Originator [ledTV=" + ledTV.GetDetails() + "]";
        }
    }
}
