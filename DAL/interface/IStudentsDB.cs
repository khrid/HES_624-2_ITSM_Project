using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DAL
{
    public interface IStudentsDB
    {
        Student GetStudentById(int id);
        List<Student> GetStudentsByUId(int uid);
        List<Student> GetStudentsByCardId(int cardid);
    }
}
