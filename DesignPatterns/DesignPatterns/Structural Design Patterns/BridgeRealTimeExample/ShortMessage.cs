using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_Design_Patterns.BridgeRealTimeExample
{
    public class ShortMessage : AbstractMessage
    {
        public ShortMessage(IMessageSender messageSender)
        {
            this.messageSender = messageSender;
        }

        public override void SendMessage(string Message)
        {
            if (Message.Length <= 10)
            {
                messageSender.SendMessage(Message);
            }
            else
            {
                Console.WriteLine("Unable to send the message as length > 10 characters");
            }
        }
    }
}
