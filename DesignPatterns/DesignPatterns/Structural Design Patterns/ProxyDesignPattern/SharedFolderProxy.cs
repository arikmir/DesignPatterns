using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_Design_Patterns.ProxyDesignPattern
{
    internal class SharedFolderProxy : ISharedFolder
    {
        private ISharedFolder _sharedFolder;
        private Employee _employee;

        public SharedFolderProxy(Employee employee)
        {
            _employee = employee;
        }

        public void PerformWriteRead()
        {
            if (_employee.Role.ToUpper() == "CEO" || _employee.Role.ToUpper() == "MANAGER")
            {
                _sharedFolder = new SharedFolder();
                Console.WriteLine("Shared Folder Proxy makes call to the RealFolder 'PerformRWOperations method'");
                _sharedFolder.PerformWriteRead();
            }
            else
            {
                Console.WriteLine("Shared Folder proxy says 'You don't have permission to access this folder'");
            }
        }
    }
}
