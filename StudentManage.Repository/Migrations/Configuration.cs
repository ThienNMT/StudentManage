using StudentManage.Domain.Entities;
using System;
using System.Data.Entity.Migrations;

namespace StudentManage.Repositories.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<StudentManage.Repositories.Data.StudentManageContext>
    {
        public Configuration()
        {
            ContextKey = "StudentManage.Repositories.Data.StudentManageContext";
            AutomaticMigrationsEnabled = true; // Set to true if you want auto-migrations
        }

        protected override void Seed(StudentManage.Repositories.Data.StudentManageContext context)
        {
            var now = DateTime.Now;

            context.Students.AddOrUpdate(i => i.Id,
                new Student() { Id = 1, CreatedDate = now, UpdatedDate = now, NRIC = "S1122331Z", Name = "Thinh", Gender = "M", Birthday = DateTime.Parse("Mar 24, 1996") },
                new Student() { Id = 2, CreatedDate = now, UpdatedDate = now, NRIC = "S1122311Z", Name = "Thao", Gender = "F", Birthday = DateTime.Parse("Nov 18, 2010") },
                new Student() { Id = 3, CreatedDate = now, UpdatedDate = now, NRIC = "S1122321Z", Name = "Thuy", Gender = "F", Birthday = DateTime.Parse("Dec 08, 2019") }
            );

            context.Subjects.AddOrUpdate(i => i.Id,
                new Subject() { Id = 1, CreatedDate = now, UpdatedDate = now, Name = "English" },
                new Subject() { Id = 2, CreatedDate = now, UpdatedDate = now, Name = "Math" }
            );

            context.StudentsSubjects.AddOrUpdate(i => i.Id,
                new StudentSubject() { Id = 1, CreatedDate = now, UpdatedDate = now, StudentId = 1, SubjectId = 1 },
                new StudentSubject() { Id = 2, CreatedDate = now, UpdatedDate = now, StudentId = 2, SubjectId = 2 },
                new StudentSubject() { Id = 3, CreatedDate = now, UpdatedDate = now, StudentId = 3, SubjectId = 2 }
            );

            context.SaveChanges();
        }
    }
}
