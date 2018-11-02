using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewLibrary1;

namespace Example03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Customer People01 = new Customer();
            People01.customerName = "Jerry";
            People01.customerHeight = 182.6f;

            Order order01 = new Order();
            order01.orderArea = "Taipei";
            string[] Type = new string[] { };
            order01.orderType = Type;

            Product product01 = new Product();
            product01.productName = "Honey";
            product01.productColor = "Yellow";

            Receipt receipt01 = new Receipt();
            receipt01.receiptNumber = 1234567;
            receipt01.receiptTitle = "Happy company";
        }
    }
}