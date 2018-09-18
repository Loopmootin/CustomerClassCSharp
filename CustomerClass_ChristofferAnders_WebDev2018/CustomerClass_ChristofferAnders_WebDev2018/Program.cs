using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerClass_ChristofferAnders_WebDev2018
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer MyCustomer = new Customer("Christoffer Andersen", 28, 3460, "miauw");

            Console.WriteLine(MyCustomer);
        }
    }
}
