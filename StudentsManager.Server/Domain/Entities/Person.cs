namespace StudentsManager.Server.Domain.Entities
{
    public class Person : Entity<Guid>
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime? BirthDate { get; set; }
        public Gender Gender { get; set; }
    }
}
