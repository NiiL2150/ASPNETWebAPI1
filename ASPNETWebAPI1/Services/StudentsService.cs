using ASPNETWebAPI1.Interfaces;
using ASPNETWebAPI1.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASPNETWebAPI1.Services
{
    public class StudentsService : IStudentsService
    {
        private int newId;
        private List<Student> _students;

        public StudentsService()
        {
            newId = 1;
            _students = new List<Student>();
        }

        public async Task<int> AddStudent(Student student)
        {
            student.Id = newId++;
            _students.Add(student);

            return student.Id ?? -1;
        }

        public async Task<bool> DeleteStudent(int id)
        {
            Student student = _students.Find(x => x.Id == id);
            if (student == null) return false;
            return _students.Remove(student);
        }

        public async Task<bool> EditStudent(Student value)
        {
            int studentIndex = _students.FindIndex(x => x.Id == value.Id);
            if (studentIndex == -1) return false;
            _students[studentIndex] = value;
            return true;
        }

        public async Task<IEnumerable<Student>> GetAllStudents()
        {
            return _students;
        }

        public async Task<Student> GetStudent(int id)
        {
            return _students.Find(stud => stud.Id == id);
        }
    }
}
