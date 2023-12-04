namespace StudentsManager.Server.Domain.Entities
{
    public class StudentsGroup : Entity<Guid>
    {
        public string Name { get; set; } = string.Empty;

        public List<Student> Students { get; set; } = new();
    }
}
