namespace NudeSolutionAssignment.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Item> Items { get ; set; } 
        public Category(int id, string name)
        {
            Id = id;
            Name = name;
            Items = new List<Item>();
        }

        public float getTotalValue() {
            float sum= 0;
            Items.ForEach(x => sum += x.Value);
            return sum;
        }
    }
}
