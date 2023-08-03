namespace AllupApp.DataAccessLayer.Entity
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int Day { get; set; }
        public string Month { get; set; }
    }
}