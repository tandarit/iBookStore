using System.Text.Json.Serialization;

namespace iBookStore.Models
{
    public class BookAuthor
    {

        [JsonIgnore]
        public int AuthorId { get; set; }


        public Author Author { get; set; }


        [JsonIgnore]
        public int BookId { get; set; }

        public Book Book { get; set; }
    }
}
