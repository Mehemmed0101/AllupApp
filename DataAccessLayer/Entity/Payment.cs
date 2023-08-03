namespace AllupApp.DataAccessLayer.Entity
{
    public class Payment
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public int FooterId { get; set; }
        public Footer Footer { get; set; }
    }
}