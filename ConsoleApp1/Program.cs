using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            People Customer = new People();

            Customer.FirstName = "Andy";
            Customer.LastName = "Estes";
            Customer.address.city = "Liberty";
            Customer.address.state = "MO";
            Customer.address.zip = "64068";

            Console.WriteLine("{0} {1} from {2},{3} {4}",
                Customer.FirstName,
            Customer.LastName,
            Customer.address.city,
            Customer.address.state,
            Customer.address.zip
                );
            return;
            

        }
    }
}
