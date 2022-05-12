using ASPNETWebAPI1.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASPNETWebAPI1.Interfaces
{
    public interface IStudentsService
    {
        Task<Student> GetStudent(int id);
        Task<IEnumerable<Student>> GetAllStudents();
        Task<int> AddStudent(Student student);
        Task<bool> DeleteStudent(int id);
        Task<bool> EditStudent(Student student);
    }
}
