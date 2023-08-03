namespace AllupApp.DataAccessLayer.Entity
{
    public class AboutUs
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int FooterId { get; set; }
        public Footer Footer { get; set; }
    }

}

