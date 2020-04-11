using DTO;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StudentsDB : IStudentsDB
    {
        private string connectionString = null;

        public StudentsDB(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Student> GetAllStudents()
        {
            List<Student> results = null;
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Students";
                    SqlCommand cmd = new SqlCommand(query, cn);

                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            if (results == null)
                                results = new List<Student>();

                            Student student = new Student();

                            student.id = (int)dr["id"];
                            student.firstname = (string)dr["firstname"];
                            student.lastname = (string)dr["lastname"];
                            student.uid = (int)dr["uid"];
                            student.cardid = (int)dr["cardid"];

                            results.Add(student);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return results;
        }

    }
}

