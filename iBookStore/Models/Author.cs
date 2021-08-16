using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace iBookStore.Models
{
    public class Author
    {                  
        public int AuthorId { get; set; }

           
       
        public string AuthorName { get; set; }

             
  
        public string Description { get; set; }

        
        [JsonIgnore]
        public ICollection<BookAuthor> BookAuthors { get; set; }


    }
}
