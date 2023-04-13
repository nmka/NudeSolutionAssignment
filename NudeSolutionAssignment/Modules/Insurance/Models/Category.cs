namespace NudeSolutionAssignment.Modules.Insurance.Models
{
    public class Category
    {
        public int Id { get; set; } = default!;
        public string Name { get; set; } = default!;

        public List<Item> Items { get; set; } = default!;

        public float GetTotalValue()
        {
            float sum = 0;
            Items.ForEach(x => sum += x.Value);
            return sum;
        }
    }
}
