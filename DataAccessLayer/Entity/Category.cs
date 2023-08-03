namespace AllupApp.DataAccessLayer.Entity
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? ImageUrl { get; set; }
        public bool isMain { get; set; }
        public int? ParentCategoryId { get; set; }
        public Category ParentCategory { get; set; }
        public int HeaderId { get; set; }
        public Header Header { get; set; }
    }
}