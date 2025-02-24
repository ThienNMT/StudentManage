using AutoMapper;
using StudentManage.Domain.DTOs;
using StudentManage.Domain.Entities;
using StudentManage.Domain.Enums;
using System.Linq;

namespace StudentManage.Domain.Profiles
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap<Student, StudentDTO>()
                    .ForMember(dest => dest.SelectedSubjects,
                                opt => opt.MapFrom(src => src.Subjects.Select(i => i.SubjectId)))
                    .ForMember(dest => dest.Gender, 
                                opt => opt.MapFrom(src => src.Gender == "M" ? Gender.Male : Gender.Female));

            CreateMap<StudentDTO, Student>()
                    .ForMember(dest => dest.Subjects, 
                                opt => opt.Ignore())
                    .ForMember(dest => dest.Gender, 
                                opt => opt.MapFrom(src => src.Gender == Gender.Male ? "M" : "F"));
        }
    }
}