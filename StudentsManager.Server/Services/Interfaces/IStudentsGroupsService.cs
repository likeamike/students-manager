using StudentsManager.Server.Domain.Entities;

namespace StudentsManager.Server.Services.Interfaces
{
    public interface IStudentsGroupsService
    {
        Task Create(StudentsGroup group);
        Task Delete(StudentsGroup group);
        Task<List<StudentsGroup>> Get();
        Task Update(StudentsGroup group);
    }
}