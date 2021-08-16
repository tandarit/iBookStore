using System.Text.Json.Serialization;

namespace iBookStore.Models
{
    public class BookFormatBook
    {
        [JsonIgnore]
        public int BookFormatId { get; set; }


        public BookFormat BookFormat { get; set; }


        [JsonIgnore]
        public int BookId { get; set; }

        public Book Book { get; set; }
    }
}
