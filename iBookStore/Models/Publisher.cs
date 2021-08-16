using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace iBookStore.Models
{
    public class Publisher
    {
        public int PublisherId { get; set; }
        public string PublisherName { get; set; }
        [JsonIgnore]
        public ICollection<Book> Books { get; set; }
    }
}
