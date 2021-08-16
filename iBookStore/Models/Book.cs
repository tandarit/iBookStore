using System.Collections.Generic;

namespace iBookStore.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public Publisher Publisher { get; set; }
        public ICollection<BookFormatBook> BookFormatBooks { get; set; }
        public ICollection<BookCategory> BookCategories { get; set; }
        public ICollection<BookAuthor> BookAuthors { get; set; }
    }
}
