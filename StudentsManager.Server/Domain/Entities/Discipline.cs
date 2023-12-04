namespace StudentsManager.Server.Domain.Entities
{
    public class Discipline : Entity<Guid>
    {
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
    }
}
