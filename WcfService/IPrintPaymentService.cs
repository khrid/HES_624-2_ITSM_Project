using DTO;
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
        [OperationContract]
        int AddTransactionByStudentId(int id, string source, double amount);

        [OperationContract]
        int AddTransactionByStudentUId(int uid, string source, double amount);

        [OperationContract]
        int AddTransactionByStudentCardId(int cardid, string source, double amount);
    }
}
