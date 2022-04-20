using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Design_Patterns.MediatorDesignPattern
{
    using System.Reflection.Metadata;

    public interface FBGroupMediator
    {
        void SendMessage(string message, User user);
        void RegisterUser(User user);
    }
}
