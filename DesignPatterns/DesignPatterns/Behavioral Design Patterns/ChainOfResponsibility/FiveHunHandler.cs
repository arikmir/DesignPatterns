using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Design_Patterns.ChainOfResponsibility
{
    public class FiveHunHandler : Handler
    {

        public override void DispatchDollars(long requested)
        {
            long toDispatch = requested / 500;
            if (toDispatch > 0)
            {
                if (toDispatch > 1)
                {
                    Console.WriteLine(toDispatch + " Five Hundred notes are dispatched by FiveHundredHandler");
                }
                else
                {
                    Console.WriteLine(toDispatch + " Five Hundred note is dispatched by FiveHundredHandler");
                }
            }

            long pendingAmount = requested % 500;
            if (pendingAmount > 0)
            {
                this._moneyHandler.DispatchDollars(pendingAmount);
            }
        }
    }
}
