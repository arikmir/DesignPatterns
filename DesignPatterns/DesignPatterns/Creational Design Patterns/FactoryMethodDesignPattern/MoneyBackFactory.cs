using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Design_Patterns.FactoryMethodDesignPattern
{
    using DesignPatterns.Creational_Design_Patterns.FactoryDesignPattern;

    public class MoneyBackFactory : CreditCardFactoryMethod
    {
        protected override CreditCard MakeProduct()
        {
            CreditCard product = new MoneyBack();
            return product;
        }
    }
}
