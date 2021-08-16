using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace iBookStore.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        [JsonIgnore]
        public ICollection<BookCategory> BookCategories { get; set; }
    }
}
