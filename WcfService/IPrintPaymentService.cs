using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Configuration;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPrintPaymentService" in both code and config file together.
    [ServiceContract]
    public interface IPrintPaymentService
    {
        /*
        [OperationContract]
        int AddTransactionByStudentId(int id, string source, double amount);

        [OperationContract]
        int AddTransactionByStudentUId(int uid, string source, double amount);

        [OperationContract]
        int AddTransactionByStudentCardId(int cardid, string source, double amount);*/


        // Flèche bleue - "PayOnline // Transfer amount of money"
        [OperationContract]
        bool TransactionPayOnline(string username, double amount); // TODO à clarifier si c'est OK avec dul, car pas précisé dans le schéma

        // Flèche bleue - "Print System // Add quotas (nb A4) through command line"
        [OperationContract]
        bool TransactionAddQuotasPrintSystem(string username, int quota);

        // Flèche verte - "Faculties // Transfer amount on money"
        [OperationContract]
        bool TransactionFaculties(string username, double amount);

        // Flèche rouge - "Payment database // Transfer amount of money through Connector after POS transaction"
        [OperationContract]
        bool TransactionPointOfSale(int uid, double amount);

        [OperationContract]
        double GetBalanceByUsername(string username);

        [OperationContract]
        double GetBalanceByUId(int uid);

    }
}
