namespace StudentsManager.Server.Domain.Entities
{
    public class Entity<T> where T : struct
    {
        public T Id { get; set; }
    }
}
