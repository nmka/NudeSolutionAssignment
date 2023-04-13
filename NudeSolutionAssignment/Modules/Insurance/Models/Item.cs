namespace NudeSolutionAssignment.Modules.Insurance.Models
{
    public class Item
    {
        public const int MinNameLength = 3;
        public const int MaxNameLength = 255;

        public int Id { get; set; } = default!;
        public string Name { get; set; } = default!;
        public int CategoryId { get; set; } = default!;
        public float Value { get; set; } = default!;



    }
}
