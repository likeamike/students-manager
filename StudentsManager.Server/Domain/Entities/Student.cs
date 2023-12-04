namespace StudentsManager.Server.Domain.Entities
{
    public class Student : Person
    {
        public byte Course { get; set; }
        
        public Guid? GroupId { get; set; }
        public StudentsGroup? Group { get; set; }
    }
}
