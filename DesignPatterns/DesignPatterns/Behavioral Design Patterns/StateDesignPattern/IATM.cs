using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Design_Patterns.StateDesignPattern
{
    public interface IATM
    {
        void InsertDebitCard();
        void EjectDebitCard();
        void EnterPin();
        void WithdrawMoney();
    }
}
