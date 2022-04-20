#region All Rights Reserved

// DesignPatterns
// Canaria Technologies 2022

#endregion

namespace DesignPatterns.Behavioral_Design_Patterns.MediatorDesignPattern
{
    public abstract class User
    {
        protected FBGroupMediator _mediator;

        protected string _userName;

        public User(FBGroupMediator mediator, string userName)
        {
            this._mediator = mediator;
            this._userName = userName;
        }
       public abstract void Send(string message);
       public abstract void Receive(string message);
    }
}