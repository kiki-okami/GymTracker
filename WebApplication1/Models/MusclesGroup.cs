namespace WebApplication1.Models
{
    public class MusclesGroup
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public List<Exercise> Exercises { get; set; } = new();
    }
}
