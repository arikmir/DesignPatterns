using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Design_Patterns.SingletonDesignPattern
{
    public sealed class SingletonSingleThread
    {
        private static int counter = 0;

        private static readonly object InstanceLock = new object();

        private static SingletonSingleThread instanceSingleThread = null;
        private SingletonSingleThread()
        {
            counter++;
            Console.WriteLine("Counter value: " + counter.ToString());
        }

        public static SingletonSingleThread GetInstance
        {
            get
            {
                if (instanceSingleThread == null)
                {
                    lock (InstanceLock)
                    {
                        if (instanceSingleThread == null)
                        {
                            instanceSingleThread = new SingletonSingleThread();
                        }
                    }
                }
                        return instanceSingleThread;

            }
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
