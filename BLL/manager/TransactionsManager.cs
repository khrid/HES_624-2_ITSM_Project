using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TransactionsManager : ITransactionsManager
    {
        private ITransactionsDB TransactionsDB { get; }
        private IStudentsManager StudentsManager { get; }

        public TransactionsManager(string connectionString)
        {
            TransactionsDB = new TransactionsDB(connectionString);
            StudentsManager = new StudentsManager(connectionString);
        }

        public Transaction AddTransactionByStudentId(int id, string source, double amount)
        {
            return TransactionsDB.AddTransaction(CreateTransactionByStudentId(id, source, amount));
        }

        public Transaction AddTransactionByStudentUId(int uid, string source, double amount)
        {
            int id = StudentsManager.GetStudentIdByUId(uid);
            return TransactionsDB.AddTransaction(CreateTransactionByStudentId(id, source, amount));
        }

        public Transaction AddTransactionByStudentCardId(int cardid, string source, double amount)
        {
            int id = StudentsManager.GetStudentIdByCardId(cardid);
            return TransactionsDB.AddTransaction(CreateTransactionByStudentId(id, source, amount));
        }

        public Transaction CreateTransactionByStudentId(int id, string source, double amount)
        {
            Transaction transaction = new Transaction();
            transaction.fk_student = id;
            transaction.source = source;
            transaction.amount = amount;
            return transaction;
        }
    }
}
