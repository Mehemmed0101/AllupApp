namespace AllupApp.DataAccessLayer.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double? Discount { get; set; }
        public double SalePrice { get; set; }
        public double? RegularPrice { get; set; }
        public string ImageUrl { get; set; }
        public string? SecondImageUrl { get; set; }
        public string? Rating { get; set; }
        public string Description { get; set; }
    }
}