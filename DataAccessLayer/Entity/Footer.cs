namespace AllupApp.DataAccessLayer.Entity
{
    public class Footer
    {
        public int Id { get; set; }
        public string BackgroundUrl { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedByLink { get; set; }
        public ICollection<Message> Message { get; set; }
        public ICollection<Details> Details { get; set; }
        public ICollection<Information> Information { get; set; }
        public ICollection<Customer> Customers { get; set; }
        public ICollection<AboutUs> AboutUs { get; set; }
        public ICollection<MyAccount> MyAccounts { get; set; }
        public ICollection<Payment> Payments { get; set; }

    }
}