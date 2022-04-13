using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Design_Patterns.ChainOfResponsibility
{
    public abstract class Handler
    {
        public Handler _moneyHandler;

        public void NextHandler(Handler moneyHandler)
        {
            this._moneyHandler = moneyHandler;
        }

        public abstract void DispatchDollars(long requested);
    }
}
