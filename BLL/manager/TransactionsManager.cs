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
        const double PRICE_PER_PAGE_BW = 0.80;
        private ITransactionsDB TransactionsDB { get; }
        private IStudentsManager StudentsManager { get; }

        public TransactionsManager(string connectionString)
        {
            TransactionsDB = new TransactionsDB(connectionString);
            StudentsManager = new StudentsManager(connectionString);
        }

        public int AddTransactionByStudentId(int id, string source, double amount)
        {
            return TransactionsDB.AddTransaction(CreateTransactionByStudentId(id, source, amount)).id;
        }

        public int AddTransactionByStudentUId(int uid, string source, double amount)
        {
            int studentId;
            try
            {
                studentId = StudentsManager.GetStudentIdByUId(uid);
            }
            catch (ApplicationException ex)
            {
                return -1;
            }
            return TransactionsDB.AddTransaction(CreateTransactionByStudentId(studentId, source, amount)).id;
        }

        public int AddTransactionByStudentCardId(int cardid, string source, double amount)
        {
            int studentId;
            try
            {
                studentId = StudentsManager.GetStudentIdByCardId(cardid);
            }
            catch (ApplicationException ex)
            {
                return -1;
            }
            return TransactionsDB.AddTransaction(CreateTransactionByStudentId(studentId, source, amount)).id;
        }

        private Transaction CreateTransactionByStudentId(int id, string source, double amount)
        {
            Transaction transaction = new Transaction();
            transaction.fk_student = id;
            transaction.source = source;
            transaction.amount = amount;
            return transaction;
        }

        public int AddTransactionByUsername(string username, string source, double amount)
        {
            int studentId;
            try
            {
                studentId = StudentsManager.GetStudentByUsername(username);
            }
            catch (ApplicationException ex)
            {
                return -1;
            }
            return TransactionsDB.AddTransaction(CreateTransactionByStudentId(studentId, source, amount)).id;
        }

        public int AddQuotaByUsername(string username, string source, int quota)
        {
            int studentId;
            try
            {
                studentId = StudentsManager.GetStudentByUsername(username);
            }
            catch (ApplicationException ex)
            {
                return -1;
            }
            return TransactionsDB.AddTransaction(CreateTransactionByStudentId(studentId, source, quota * PRICE_PER_PAGE_BW)).id;
        }
    }
}
