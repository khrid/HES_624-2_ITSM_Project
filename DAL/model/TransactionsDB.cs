using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TransactionsDB : ITransactionsDB
    {

        private string connectionString = null;

        public TransactionsDB(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public Transaction AddTransaction(Transaction transaction)
        {

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Transactions(source, amount, fk_student, created_at) VALUES(@source, @amount, @fk_student, CURRENT_TIMESTAMP); SELECT SCOPE_IDENTITY()";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@source", transaction.source);
                    cmd.Parameters.AddWithValue("@amount", transaction.amount);
                    cmd.Parameters.AddWithValue("@fk_student", transaction.fk_student);
                    

                    cn.Open();

                    transaction.id = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return transaction;
        }

    }
    
}
