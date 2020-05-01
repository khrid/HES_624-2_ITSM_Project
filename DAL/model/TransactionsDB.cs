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

        public double GetBalanceByStudentId(int studentId)
        {

            double result = 0;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT SUM(amount) AS balance FROM Transactions WHERE fk_student=@fk_student";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@fk_student", studentId);
                    
                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            if (dr["balance"] != DBNull.Value)
                                result = (double)((decimal)dr["balance"]); // double conversion à éviter (obliger car les données sont de type decimal dans la DB et de type double dans le webservice) 
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }

    }
    
}
