using System.Text.Json.Serialization;

namespace iBookStore.Models
{
    public class BookCategory
    {
        [JsonIgnore]
        public int BookId { get; set; }
        public Book Book { get; set; }
        [JsonIgnore]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
