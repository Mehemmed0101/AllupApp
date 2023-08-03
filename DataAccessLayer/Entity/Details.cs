namespace AllupApp.DataAccessLayer.Entity
{
    public class Details
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Number { get; set; }
        public string Email { get; set; }
        public string WorkTime { get; set; }
        public int FooterId { get; set; }
        public Footer Footer { get; set; }

    }
}