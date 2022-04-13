using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Design_Patterns.ChainOfResponsibility
{
    public class TwoKHandler : Handler
    {
        public override void DispatchDollars(long requested)
        {
            long toDispatch = requested / 2000;
            if (toDispatch >0)
            {
                if (toDispatch >1)
                {
                    Console.WriteLine(toDispatch + " Two Thousand notes are dispatched by TwoThousandHandler");
                }
                else
                {
                    Console.WriteLine(toDispatch + " Two Thousand note is dispatched by TwoThousandHandler");
                }
            }

            long pendingAmount = requested % 2000;
            if (pendingAmount >0)
            {
                this._moneyHandler.DispatchDollars(pendingAmount);
            }
        }
    }
}
