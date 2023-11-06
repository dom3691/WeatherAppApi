namespace MovieManager.Model
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Rating { get; set; }
        public decimal TicketPrice { get; set; }
        public string Country { get; set; }
        public List<string> Genre { get; set; }
        public string Photo { get; set; }
    }
}
