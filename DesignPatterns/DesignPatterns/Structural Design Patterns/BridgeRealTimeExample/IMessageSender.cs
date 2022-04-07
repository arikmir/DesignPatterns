using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_Design_Patterns.BridgeRealTimeExample
{
    public interface IMessageSender
    {
        void SendMessage(string Message);
    }
}
