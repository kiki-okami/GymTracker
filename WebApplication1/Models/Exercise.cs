namespace WebApplication1.Models
{
    public class Exercise
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public int MusclesGroupId { get; set; }          // klucz obcy
        public MusclesGroup MuscleGroup { get; set; } = null!;  // nawigacja
    }
}
