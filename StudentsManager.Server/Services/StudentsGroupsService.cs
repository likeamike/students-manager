using Microsoft.EntityFrameworkCore;
using StudentsManager.Server.Domain.Context;
using StudentsManager.Server.Domain.Entities;
using StudentsManager.Server.Services.Interfaces;

namespace StudentsManager.Server.Services
{
    public class StudentsGroupsService : IStudentsGroupsService
    {
        private readonly MainContext MainContext;

        public StudentsGroupsService(MainContext context)
        {
            MainContext = context;
        }

        public async Task<List<StudentsGroup>> Get()
        {
            return await MainContext.StudentsGroups.ToListAsync();
        }

        public async Task Update(StudentsGroup group)
        {
            MainContext.StudentsGroups.Update(group);
            await MainContext.SaveChangesAsync();
        }

        public async Task Delete(StudentsGroup group)
        {
            MainContext.StudentsGroups.Remove(group);
            await MainContext.SaveChangesAsync();
        }

        public async Task Create(StudentsGroup group)
        {
            await MainContext.StudentsGroups.AddAsync(group);
            await MainContext.SaveChangesAsync();
        }
    }
}
