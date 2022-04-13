using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Design_Patterns.ChainOfResponsibility
{
    public class ATM
    {
        private TwoKHandler twoKHandler = new TwoKHandler();
        private FiveHunHandler fiveHunHandler = new FiveHunHandler();
        private TwoHunHandler twoHunHandler = new TwoHunHandler();
        private HundredHandler hundredHandler = new HundredHandler();

        public ATM()
        {
            //chain of Handlers
            this.twoKHandler.NextHandler(this.fiveHunHandler);
            this.fiveHunHandler.NextHandler(this.twoHunHandler);
            this.twoHunHandler.NextHandler(this.hundredHandler);
        }

        public void Withdraw(long requestAmount)
        {
            this.twoKHandler.DispatchDollars(requestAmount);
        }
    }
}
