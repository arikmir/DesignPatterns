using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Design_Patterns.ObserverDesignPattern
{
    public class Subject : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();

        private string ProductName { get; set; }

        private int  ProductPrice { get; set; }

        private string Availibility { get; set; }

        public Subject(string productName, int productPrice, string availibility)
        {
            ProductName = productName;
            ProductPrice = productPrice;
            Availibility = availibility;
        }

        public string GetAvailibility()
        {
            return Availibility;
        }

        public void SetAvailibility(string availibility)
        {
            this.Availibility = availibility;
            Console.WriteLine("Availability changed from Out of Stock to Available.");
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            this.observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            Console.WriteLine("Product Name :"
                              + ProductName + ", product Price : "
                              + ProductPrice + " is Now available. So notifying all Registered users ");
            Console.WriteLine();
            foreach (IObserver observer in observers)
            {
                observer.update(Availibility);
            }
        }
    }
}
