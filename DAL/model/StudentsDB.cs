using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DAL
{
    public class StudentsDB : IStudentsDB
    {

        private string connectionString = null;

        public StudentsDB(string connectionString)
        {
            this.connectionString = connectionString;
        }

       

        public Student GetStudentById(int id)
        {
            Student result = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "Select * from Students where id=@id";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@id", id);

                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        if (dr.Read())
                        {

                            if (result == null)
                                result = new Student();

                            result.id = (int)dr["id"];
                            result.firstname = (string)dr["firstname"];
                            result.lastname = (string)dr["lastname"];
                            result.username = (string)dr["username"];
                            result.uid = (int)dr["uid"];
                            result.cardid = (int)dr["cardid"];

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

        public List<Student> GetStudentsByCardId(int cardid)
        {
            List<Student> results = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "Select * from Students where cardid=@cardid";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@cardid", cardid);

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
                            student.username = (string)dr["username"];
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
    

        public List<Student> GetStudentsByUId(int uid)
        {
            List<Student> results = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "Select * from Students where uid=@uid";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@uid", uid);

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
                            student.username = (string)dr["username"];
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

        public List<Student> GetStudentsByUsername(string username)
        {
            List<Student> results = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "Select * from Students where username=@username";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@username", username);

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
                            student.username = (string)dr["username"];
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
