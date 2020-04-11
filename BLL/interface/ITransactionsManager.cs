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
        int AddTransactionByStudentId(int id, string source, double amount);

        int AddTransactionByStudentUId(int uid, string source, double amount);

        int AddTransactionByStudentCardId(int cardid, string source, double amount);

        int AddTransactionByUsername(string username, string source, double amount);

        int AddQuotaByUsername(string username, string source, int quota);

    }
}
