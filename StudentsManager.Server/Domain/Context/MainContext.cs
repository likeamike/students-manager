using Microsoft.EntityFrameworkCore;
using StudentsManager.Server.Domain.Entities;

namespace StudentsManager.Server.Domain.Context
{
    public class MainContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<StudentsGroupDiscipline> StudentsGroupDisciplines { get; set; }
        public DbSet<StudentsGroup> StudentsGroups { get; set; }

        public MainContext(DbContextOptions<MainContext> options): base(options) { }
    }
}
