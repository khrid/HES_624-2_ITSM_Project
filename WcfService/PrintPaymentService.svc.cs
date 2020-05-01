using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Configuration;
using BLL;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PrintPaymentService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PrintPaymentService.svc or PrintPaymentService.svc.cs at the Solution Explorer and start debugging.
    public class PrintPaymentService : IPrintPaymentService
    {

        public static string connectionString { get; } = ConfigurationManager.ConnectionStrings["dbProject"].ConnectionString;

        private ITransactionsManager TransactionsManager = new TransactionsManager(connectionString);

        /*public int AddTransactionByStudentId(int id, string source, double amount)
        {
            return TransactionsManager.AddTransactionByStudentId(id, source, amount).id;
        }


        public int AddTransactionByStudentUId(int uid, string source, double amount)
        {
            return TransactionsManager.AddTransactionByStudentUId(uid, source, amount).id;
        }

        public int AddTransactionByStudentCardId(int cardid, string source, double amount)
        {
            return TransactionsManager.AddTransactionByStudentCardId(cardid, source, amount).id;
        }*/

        public bool TransactionPayOnline(string username, double amount)
        {
            return TransactionsManager.AddTransactionByUsername(username, "PayOnline", amount) !=-1;
        }

        public bool TransactionAddQuotasPrintSystem(string username, int quota)
        {
            return TransactionsManager.AddQuotaByUsername(username, "PrintSystem", quota) != -1;
        }

        public bool TransactionFaculties(string username, double amount)
        {
            return TransactionsManager.AddTransactionByUsername(username, "Faculties", amount) != -1;
        }

        public bool TransactionPointOfSale(int uid, double amount)
        {
            return TransactionsManager.AddTransactionByStudentUId(uid, "PointOfSale", amount) != -1;
        }

        public double GetBalanceByUsername(string username)
        {
            return TransactionsManager.GetBalanceByStudentUsername(username);
        }

        public double GetBalanceByUId(int uid)
        {
            return TransactionsManager.GetBalanceByStudentUId(uid);
        }
    }
}
