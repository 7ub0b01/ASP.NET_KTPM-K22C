namespace Day3.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }

        //foreign key to Category
        public int CategoryId { get; set; }

        //navigation property to Category
        public Category Category { get; set; } = null!;
    }
}
