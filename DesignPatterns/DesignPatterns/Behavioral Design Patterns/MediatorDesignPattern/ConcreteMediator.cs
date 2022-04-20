using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Design_Patterns.MediatorDesignPattern
{
    public class ConcreteMediator : FBGroupMediator
    {
        private List<User> usersList = new List<User>();
        public void SendMessage(string message, User user)
        {
            foreach (var receiver in usersList)
            {
                if (receiver != user)
                {
                    receiver.Receive(message);
                }
            }
        }

        public void RegisterUser(User user)
        {
            this.usersList.Add(user);
        }
    }
}
