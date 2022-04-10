using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Design_Patterns.ObserverDesignPattern
{
    public class Observer : IObserver
    {
        public string UserName { get; set; }

        public Observer(string userName, ISubject subject)
        {
            UserName = userName;
            subject.RegisterObserver(this);
        }

        public void update(string availability)
        {
            Console.WriteLine("Hello " + UserName + ", Product is now " + availability + " on Amazon");
        }
    }
}

