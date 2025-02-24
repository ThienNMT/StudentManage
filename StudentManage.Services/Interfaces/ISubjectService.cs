using StudentManage.Domain.Entities;
using System.Collections.Generic;

namespace StudentManage.Services.Interfaces
{
    public interface ISubjectService
    {
        IEnumerable<Subject> GetSubjects();
        IEnumerable<Subject> GetSubjectsByStudent(int id);
    }
}
