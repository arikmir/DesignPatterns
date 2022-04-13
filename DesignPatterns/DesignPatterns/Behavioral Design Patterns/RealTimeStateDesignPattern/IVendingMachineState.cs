using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Design_Patterns.RealTimeStateDesignPattern
{
    public interface IVendingMachineState
    {
        void SelectProductAndInsertMoney(int amount, String productName);
        void DispenseProduct();
    }
}
