namespace AllupApp.DataAccessLayer.Entity
{
    public class Message
    {
        public int Id { get; set; }
        public string CoverUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int FooterId { get; set; }
        public Footer Footer { get; set; }
    }
}