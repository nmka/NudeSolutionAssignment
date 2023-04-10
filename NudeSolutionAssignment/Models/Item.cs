namespace NudeSolutionAssignment.Models
{
    public class Item
    {
        public const int MinNameLength = 3;
        public const int MaxNameLength = 255;

        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public float Value { get; set; }

        public Item( string name, int categoryId, float value) { 
            Name = name; 
            CategoryId = categoryId;
            Value = value;
        }

        
    }
}
