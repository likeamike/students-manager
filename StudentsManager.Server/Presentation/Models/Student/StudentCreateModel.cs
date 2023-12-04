namespace StudentsManager.Server.Presentation.Models.Student
{
    public class StudentCreateModel
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime? BirthDate { get; set; }
        public string Gender { get; set; } = string.Empty;
        public Guid? GroupId { get; set; }
    }
}
