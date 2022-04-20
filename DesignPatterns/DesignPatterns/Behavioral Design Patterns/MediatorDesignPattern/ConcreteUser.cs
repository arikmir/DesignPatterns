using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Design_Patterns.MediatorDesignPattern
{
    public class ConcreteUser : User
    {
        public ConcreteUser(FBGroupMediator mediator, string userName)
            : base(mediator, userName)
        {
        }

        public override void Receive(string message)
        {
            Console.WriteLine(this._userName + ": Received Message:" + message);
        }
        public override void Send(string message)
        {
            Console.WriteLine(this._userName + ": Sending Message=" + message + "\n");
            this._mediator.SendMessage(message, this);
        }
    }
}
