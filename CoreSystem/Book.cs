using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoreSystem
{
    public class Book
    {
        public string Id { get; private set; }
        public string Title { get; private set; }
        public string Publications { get; private set; }
        public List<PersonName> Authors { get; private set; }
        public Genre Genre { get; private set; }
        public static Book Empty => null;

        public Book(string id,string title,string publications,List<PersonName> authors,Genre genre)
        {
            Id = id;
            Title = title;
            Publications = publications;
            Authors = authors;
            Genre = Genre;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
