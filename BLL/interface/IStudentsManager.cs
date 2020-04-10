using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IStudentsManager
{
        Student GetStudentById(int id);

        List<Student> GetStudentsByUId(int uid);
        
        List<Student> GetStudentsByCardId(int cardid);
        
        int GetStudentIdByUId(int uid);
        
        int GetStudentIdByCardId(int cardid);

    }
}
