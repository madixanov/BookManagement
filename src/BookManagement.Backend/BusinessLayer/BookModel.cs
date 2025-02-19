namespace BusinessLayer
{
    public class BookModel
    {
        public string? Title { get; set; }
        public DateOnly PublishedDay { get; set; }
        public string? AuthorName { get; set; }
        public int Views { get; set; }
    }
}
