using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamousQouteQuiz.Domain.Entities
{
    public class Author
    {
        public Author()
        {
            this.Quotes = new List<Quote>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public IList<Quote> Quotes { get; set; }
    }
}
