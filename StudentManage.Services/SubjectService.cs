﻿using StudentManage.Domain.Entities;
using StudentManage.Repositories.Interfaces;
using StudentManage.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace StudentManage.Services
{
    public class SubjectService : ISubjectService
    {
        private readonly IGenericRepository<Subject> _subjectRepo;
        private readonly IGenericRepository<StudentSubject> _studentSubjectRepo;

        public SubjectService(
            IGenericRepository<Subject> subjectRepo,
            IGenericRepository<StudentSubject> studentSubjectRepo
            )
        {
            _subjectRepo = subjectRepo;
            _studentSubjectRepo = studentSubjectRepo;
        }

        public IEnumerable<Subject> GetSubjects()
        {
            return _subjectRepo.GetAll();
        }

        public IEnumerable<Subject> GetSubjectsByStudent(int id)
        {
            var subjectIds = _studentSubjectRepo.Where(ss => ss.StudentId == id).Select(ss => ss.SubjectId).ToList();
            var subjects = _subjectRepo.Where(s => subjectIds.Contains(s.Id));
            return subjects;
        }
    }
}