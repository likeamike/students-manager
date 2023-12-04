using AutoMapper;
using StudentsManager.Server.Domain.Entities;
using StudentsManager.Server.Presentation.Models.Student;

namespace StudentsManager.Server.Mappings
{
    public class StudentsProfile : Profile
    {
        public StudentsProfile() 
        { 
            CreateMap<Student, StudentModel>();
            CreateMap<StudentModel, Student>();
            CreateMap<StudentCreateModel, Student>();
        }
    }
}
