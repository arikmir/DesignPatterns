using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_Design_Patterns.FacadeDesignPattern
{
    //https://dotnettutorials.net/lesson/facade-design-pattern/
    public class Order
    {
        public void PlaceOrder()
        {
            Console.WriteLine("Place Order Started");
            Product product = new Product();
            product.GetProductDetails();
            Payment payment = new Payment();
            payment.MakePayment();
            Invoice invoice = new Invoice();
            invoice.SendInvoice();
            Console.WriteLine("Order Placed Successfully");
        }
    }
}
