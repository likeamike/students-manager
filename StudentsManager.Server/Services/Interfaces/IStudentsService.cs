using StudentsManager.Server.Domain.Entities;

namespace StudentsManager.Server.Services.Interfaces
{
    public interface IStudentsService
    {
        Task Create(Student student);
        Task Delete(Guid id);
        IQueryable<Student> Get();
        Task Update(Student student);
    }
}