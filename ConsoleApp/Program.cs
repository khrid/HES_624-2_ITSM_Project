using BLL;
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

            //int id = 2;
            //Console.WriteLine(id + " " + client.GetStudentById(id));

            // TEST COMMIT BRANCH SYLVAIN

            //Gérer id inexistant
            //Console.WriteLine("Transaction successfully inserted. id -> " + client.AddTransactionByStudentId(3,"payment",5.65));
            //Console.WriteLine("Transaction successfully inserted. id -> " + client.AddTransactionByStudentUId(6577, "payment", 5.65));
            Console.WriteLine("Transaction successfully inserted. id -> " + client.AddTransactionByStudentCardId(2565, "payment", 3.4));
            Console.ReadLine();

        }

    }
}
