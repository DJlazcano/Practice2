namespace Practice2.LibraryA
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }

        public Book(string title, int bookId)
        {
            Title = title;
            BookId = bookId;
        }

        public override string ToString()
        {
            return $"Book Title: {Title}, BookId: {BookId}";
        }
    }
}
