using AutoMapper;
using StudentsManager.Server.Domain.Entities;
using StudentsManager.Server.Presentation.Models.StudentsGroup;

namespace StudentsManager.Server.Mappings
{
    public class StudentsGroupsProfile : Profile
    {
        public StudentsGroupsProfile() 
        {
            CreateMap<StudentsGroup, StudentsGroupModel>();
            CreateMap<StudentsGroupModel, StudentsGroup>();
        }
    }
}
