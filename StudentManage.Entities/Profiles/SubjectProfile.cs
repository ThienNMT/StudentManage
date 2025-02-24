using AutoMapper;
using StudentManage.Domain.DTOs;
using StudentManage.Domain.Entities;

namespace StudentManage.Domain.Profiles
{
    public class SubjectProfile : Profile
    {
        public SubjectProfile()
        {
            CreateMap<Subject, StudentDTO>();
        }
    }
}