using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_Design_Patterns.ProxyDesignPattern
{
    public class SharedFolder : ISharedFolder
    {
        public void PerformWriteRead()
        {
            Console.WriteLine("Performing Read Write operation on the Shared Folder");
        }
    }
}
