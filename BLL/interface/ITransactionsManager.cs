using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface ITransactionsManager
{
        Transaction AddTransactionByStudentId(int id, string source, double amount);

        Transaction AddTransactionByStudentUId(int uid, string source, double amount);

        Transaction AddTransactionByStudentCardId(int cardid, string source, double amount);

        Transaction CreateTransactionByStudentId(int id, string source, double amount);
    }
}
