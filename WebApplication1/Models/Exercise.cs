namespace WebApplication1.Models
{
    public class Exercise
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public int MuscleGroupId { get; set; }          // klucz obcy
        public MuscleGroup MuscleGroup { get; set; } = null!;  // nawigacja
    }
}
