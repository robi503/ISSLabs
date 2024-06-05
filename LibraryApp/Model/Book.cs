namespace LibraryApp.Model
{
    public class Book(string title, string author, string genre, bool rented)
    {
        public int Id { get; set; }
        public string Title { get; set; } = title;
        public string Author { get; set; } = author;
        public string Genre { get; set; } = genre;
        public bool Rented { get; set; } = rented;
    }
}
