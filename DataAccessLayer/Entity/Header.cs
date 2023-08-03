namespace AllupApp.DataAccessLayer.Entity
{
    public class Header
    {
        public int Id { get; set; }
        public string LogoUrl { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}