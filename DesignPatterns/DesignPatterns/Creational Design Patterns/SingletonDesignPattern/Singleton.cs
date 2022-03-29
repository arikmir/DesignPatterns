using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Design_Patterns.SingletonDesignPattern
{
    //https://dotnettutorials.net/lesson/singleton-design-pattern/
    public sealed class Singleton
    {
        private static Singleton instance = null;

        //eager loading
        //private static readonly Singleton singleInstance = new Singleton();

        //lazy loading
        //private static readonly Lazy<Singleton> InstanceLock = new Lazy<Singleton>(() => new Singleton());


        private static int counter = 0;
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();

                return instance;
                //eager loading
                //return instance;

                //lazy loading
                //return InstanceLock.Value;
            }
        }
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
