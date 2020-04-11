using DTO;
using System.Collections.Generic;

namespace DAL
{
    public interface IStudentsDB
    {
        List<Student> GetAllStudents();
    }
}