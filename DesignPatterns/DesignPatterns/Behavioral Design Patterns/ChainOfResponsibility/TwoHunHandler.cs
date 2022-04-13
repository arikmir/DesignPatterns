using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Design_Patterns.ChainOfResponsibility
{
    public class TwoHunHandler: Handler
    {
        public override void DispatchDollars(long requested)
        {
            long toDispatch = requested / 200;
            if (toDispatch > 0)
            {
                if (toDispatch > 1)
                {
                    Console.WriteLine(toDispatch + " Two Hundred notes are dispatched by TwoHundredHandler");
                }
                else
                {
                    Console.WriteLine(toDispatch + " Two Hundred note is dispatched by TwoHundredHandler");
                }
            }

            long pendingAmount = requested % 200;
            if (pendingAmount > 0)
            {
                this._moneyHandler.DispatchDollars(pendingAmount);
            }
        }
    }
}
