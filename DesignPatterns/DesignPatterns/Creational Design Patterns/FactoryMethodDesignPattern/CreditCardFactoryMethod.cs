using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://dotnettutorials.net/lesson/factory-method-design-pattern-csharp/

namespace DesignPatterns.Creational_Design_Patterns.FactoryMethodDesignPattern
{
    using DesignPatterns.Creational_Design_Patterns.FactoryDesignPattern;

    public abstract class CreditCardFactoryMethod
    {
        protected abstract CreditCard MakeProduct();

        public CreditCard CreateProduct()
        {
            return this.MakeProduct();
        }
    }
}
