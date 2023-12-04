namespace StudentsManager.Server.Domain.Entities
{
    public class StudentsGroupDiscipline : Entity<Guid>
    {
        public Guid? StudentsGroupId { get; set; }
        public StudentsGroup? StudentsGroup { get; set; }

        public Guid? DisciplineId { get; set; }
        public Discipline? Discipline { get; set; }

        public Guid? TeacherId { get; set; }
        public Teacher? Teacher { get; set; }
    }
}
