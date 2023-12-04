using StudentsManager.Server.Presentation.Models.StudentsGroup;

namespace StudentsManager.Server.Presentation.Models.Student
{
    public class StudentModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime? BirthDate { get; set; }
        public string Gender { get; set; } = string.Empty;
        public StudentsGroupModel? Group { get; set; }
    }
}
