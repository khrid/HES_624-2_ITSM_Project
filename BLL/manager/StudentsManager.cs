using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public class StudentsManager : IStudentsManager
    {
        private IStudentsDB StudentsDB { get; } 

        public StudentsManager(string connectionString)
        {
            StudentsDB = new StudentsDB(connectionString);
        }

        public List<Student> GetAllStudents()
        {
            return StudentsDB.GetAllStudents();
        }

        public Student GetStudent(int id)
        {
            Student student = null;
            List<Student> allStudents = GetAllStudents();
            foreach (var s in allStudents)
            {
                if(s.id == id)
                {
                    student = s;
                }
            }
            return student;
        }
    }
}
