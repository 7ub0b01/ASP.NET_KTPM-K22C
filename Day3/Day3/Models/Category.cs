namespace Day3.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        //public string Action { get; set; }

        //navigation property to Product
        public List<Product> Products { get; set; } = new List<Product>();

    }
}
