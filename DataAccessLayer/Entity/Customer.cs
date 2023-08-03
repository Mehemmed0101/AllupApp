namespace AllupApp.DataAccessLayer.Entity
{
    public class Customer
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int FooterId { get; set; }
        public Footer Footer { get; set; }
    }
}