using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintPaymentServiceReference.PrintPaymentServiceClient client = new PrintPaymentServiceReference.PrintPaymentServiceClient();
            Console.WriteLine(client.SayHello(2));
            Console.ReadLine();
        }
    }
}
