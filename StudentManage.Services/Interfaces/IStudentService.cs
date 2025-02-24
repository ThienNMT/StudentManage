using StudentManage.Domain.Entities;
using System.Collections.Generic;

namespace StudentManage.Services.Interfaces
{
    public interface IStudentService
    {
        Student CreateStudent(Student model);
        Student UpdateStudent(Student model);
        Student GetStudent(int id);
        IEnumerable<Student> GetStudents();
        IEnumerable<Student> GetStudents(string searchValue);
    }
}
