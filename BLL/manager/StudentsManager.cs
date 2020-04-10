using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class StudentsManager : IStudentsManager
    {
        private IStudentsDB StudentsDB { get; }

        public StudentsManager(string connectionString)
        {
            StudentsDB = new StudentsDB(connectionString);
        }

        public Student GetStudentById(int id)
        {
            return StudentsDB.GetStudentById(id);
        }

        public List<Student> GetStudentsByUId(int uid)
        {
            return StudentsDB.GetStudentsByUId(uid);
        }

        public List<Student> GetStudentsByCardId(int cardid)
        {
            return StudentsDB.GetStudentsByCardId(cardid);
        }

        public int GetStudentIdByUId(int uid)
        {
            List<Student> students = GetStudentsByUId(uid);
            if (students == null)
            {
                throw new System.ApplicationException("No record found in table 'Students' with 'uid' " + uid + ".");
            }
            else if (students.Count > 1)
            {
                throw new System.ApplicationException("Column 'uid' in table 'Students' contains a duplicate value '" + uid + "'. " + students.Count + " values found.");
            }
            else
            {
                return students[0].id;
            }
        }

        public int GetStudentIdByCardId(int cardid)
        {
            List<Student> students = GetStudentsByCardId(cardid);
            if (students == null)
            {
                throw new System.ApplicationException("No record found in table 'Students' with 'cardid' " + cardid + ".");
            }
            else if (students.Count > 1)
            {
                throw new System.ApplicationException("Column 'cardid' in table 'Students' contains a duplicate value '" + cardid + "'. " + students.Count + " values found.");
            }
            else
            {
                return students[0].id;
            }
        }
    }
}
