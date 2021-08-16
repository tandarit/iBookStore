using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace iBookStore.Models
{
    public class BookFormat
    {
            public int BookFormatId { get; set; }



            public string BookFormatName { get; set; }



            public string Description { get; set; }


            [JsonIgnore]
            public ICollection<BookFormatBook> BookFormatBooks { get; set; }


        }

    }

