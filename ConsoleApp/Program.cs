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

            //TEST

            // Happy path
            Console.WriteLine("------ TEST HAPPY PATH ------");

            // -> Point of sale
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("--- POINT OF SALE ---");
            Console.ReadLine();
            Console.WriteLine("Getting balance for student identified by UID 7789 ...");
            Console.ReadLine();
            Console.WriteLine("Current balance -> " + client.GetBalanceByUId(7789));
            Console.ReadLine();
            Console.WriteLine("Trying to add 10.- CHF to student identified by UID 7789 ...");
            Console.ReadLine();
            Console.WriteLine("Transaction successfully done -> " + client.TransactionPointOfSale(7789, 10));
            Console.ReadLine();
            Console.WriteLine("Getting new balance ...");
            Console.ReadLine();
            Console.WriteLine("New balance -> " + client.GetBalanceByUId(7789));
            Console.ReadLine();

            // -> Pay online
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("--- PAY ONLINE ---");
            Console.ReadLine();
            Console.WriteLine("Getting balance for student identified by username sylvain.meyer ...");
            Console.ReadLine();
            Console.WriteLine("Current balance -> " + client.GetBalanceByUsername("sylvain.meyer"));
            Console.ReadLine();
            Console.WriteLine("Trying to add 5.45 CHF to student identified by username sylvain.meyer ...");
            Console.ReadLine();
            Console.WriteLine("Transaction successfully done -> " + client.TransactionPayOnline("sylvain.meyer", 5.45));
            Console.ReadLine();
            Console.WriteLine("Getting new balance ...");
            Console.ReadLine();
            Console.WriteLine("New balance -> " + client.GetBalanceByUsername("sylvain.meyer"));
            Console.ReadLine();

            // -> Faculties
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("--- FACULTIES ---");
            Console.ReadLine();
            Console.WriteLine("Getting balance for student identified by username david.crittin ...");
            Console.ReadLine();
            Console.WriteLine("Current balance -> " + client.GetBalanceByUsername("david.crittin"));
            Console.ReadLine();
            Console.WriteLine("Trying to add 12.- CHF to student identified by username david.crittin ...");
            Console.ReadLine();
            Console.WriteLine("Transaction successfully done -> " + client.TransactionFaculties("david.crittin", 12));
            Console.ReadLine();
            Console.WriteLine("Getting new balance ...");
            Console.ReadLine();
            Console.WriteLine("New balance -> " + client.GetBalanceByUsername("david.crittin"));
            Console.ReadLine();

            // -> Print system
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("--- PRINT SYSTEM ---");
            Console.ReadLine();
            Console.WriteLine("Getting balance for student identified by username alain.duc ...");
            Console.ReadLine();
            Console.WriteLine("Current balance -> " + client.GetBalanceByUsername("alain.duc"));
            Console.ReadLine();
            Console.WriteLine("Trying to add 10 pages to student's quota identified by username alain.duc ...");
            Console.ReadLine();
            Console.WriteLine("Transaction successfully done -> " + client.TransactionAddQuotasPrintSystem("alain.duc", 10));
            Console.ReadLine();
            Console.WriteLine("Getting new balance ...");
            Console.ReadLine();
            Console.WriteLine("New balance -> " + client.GetBalanceByUsername("alain.duc"));
            Console.ReadLine();


            // id inexistants
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("------ TEST ID INEXISTANTS ------");

            // -> Point of sale
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("--- POINT OF SALE ---");
            Console.ReadLine();
            Console.WriteLine("Getting balance for student identified by UID 1478 ...");
            Console.ReadLine();
            Console.WriteLine("Current balance -> " + client.GetBalanceByUId(1478));
            Console.ReadLine();
            Console.WriteLine("Trying to add 10.- CHF to student identified by UID 1478 ...");
            Console.ReadLine();
            Console.WriteLine("Transaction successfully done -> " + client.TransactionPointOfSale(1478, 10));
            Console.ReadLine();
            Console.WriteLine("Getting new balance ...");
            Console.ReadLine();
            Console.WriteLine("New balance -> " + client.GetBalanceByUId(1478));
            Console.ReadLine();

            // -> Pay online
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("--- PAY ONLINE ---");
            Console.ReadLine();
            Console.WriteLine("Getting balance for student identified by username michel.vincent ...");
            Console.ReadLine();
            Console.WriteLine("Current balance -> " + client.GetBalanceByUsername("michel.vincent"));
            Console.ReadLine();
            Console.WriteLine("Trying to add 5.45 CHF to student identified by username michel.vincent ...");
            Console.ReadLine();
            Console.WriteLine("Transaction successfully done -> " + client.TransactionPayOnline("michel.vincent", 5.45));
            Console.ReadLine();
            Console.WriteLine("Getting new balance ...");
            Console.ReadLine();
            Console.WriteLine("New balance -> " + client.GetBalanceByUsername("michel.vincent"));
            Console.ReadLine();

            // -> Faculties
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("--- FACULTIES ---");
            Console.ReadLine();
            Console.WriteLine("Getting balance for student identified by username nicolas.debons ...");
            Console.ReadLine();
            Console.WriteLine("Current balance -> " + client.GetBalanceByUsername("nicolas.debons"));
            Console.ReadLine();
            Console.WriteLine("Trying to add 12.- CHF to student identified by username nicolas.debons ...");
            Console.ReadLine();
            Console.WriteLine("Transaction successfully done -> " + client.TransactionFaculties("nicolas.debons", 12));
            Console.ReadLine();
            Console.WriteLine("Getting new balance ...");
            Console.ReadLine();
            Console.WriteLine("New balance -> " + client.GetBalanceByUsername("nicolas.debons"));
            Console.ReadLine();

            // -> Print system
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("--- PRINT SYSTEM ---");
            Console.ReadLine();
            Console.WriteLine("Getting balance for student identified by username anne.lecalve ...");
            Console.ReadLine();
            Console.WriteLine("Current balance -> " + client.GetBalanceByUsername("anne.lecalve"));
            Console.ReadLine();
            Console.WriteLine("Trying to add 10 pages to student's quota identified by username anne.lecalve ...");
            Console.ReadLine();
            Console.WriteLine("Transaction successfully done -> " + client.TransactionAddQuotasPrintSystem("anne.lecalve", 10));
            Console.ReadLine();
            Console.WriteLine("Getting new balance ...");
            Console.ReadLine();
            Console.WriteLine("New balance -> " + client.GetBalanceByUsername("anne.lecalve"));
            Console.ReadLine();


        }

    }
}
