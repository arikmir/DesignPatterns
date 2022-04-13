using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Design_Patterns.ChainOfResponsibility
{
    public class HundredHandler : Handler
    {
        public override void DispatchDollars(long requested)
        {
            long toDispatch = requested / 100;
            if (toDispatch > 0)
            {
                if (toDispatch > 1)
                {
                    Console.WriteLine(toDispatch + " Hundred notes are dispatched by TwoHundredHandler");
                }
                else
                {
                    Console.WriteLine(toDispatch + " Hundred note is dispatched by TwoHundredHandler");
                }
            }

            long pendingAmount = requested % 100;
            if (pendingAmount > 0)
            {
                this._moneyHandler.DispatchDollars(pendingAmount);
            }
        }
    }
}
