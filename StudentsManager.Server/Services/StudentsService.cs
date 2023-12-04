using Microsoft.EntityFrameworkCore;
using StudentsManager.Server.Domain.Context;
using StudentsManager.Server.Domain.Entities;
using StudentsManager.Server.Services.Interfaces;

namespace StudentsManager.Server.Services
{
    public class StudentsService : IStudentsService
    {
        private readonly MainContext MainContext;

        public StudentsService(MainContext context)
        {
            MainContext = context;
        }

        public IQueryable<Student> Get()
        {
            return MainContext.Students.AsQueryable();
        }

        public async Task Update(Student student)
        {
            student.Group = null;
            MainContext.Students.Update(student);
            await MainContext.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            var student = await MainContext.Students.FirstOrDefaultAsync(s => s.Id == id);

            if (student is null)
                throw new KeyNotFoundException(id.ToString());

            MainContext.Students.Remove(student);
            await MainContext.SaveChangesAsync();
        }

        public async Task Create(Student student)
        {
            await MainContext.Students.AddAsync(student);
            await MainContext.SaveChangesAsync();
        }
    }
}
