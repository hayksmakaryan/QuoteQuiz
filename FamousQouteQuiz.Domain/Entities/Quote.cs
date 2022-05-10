using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamousQouteQuiz.Domain.Entities
{
    public class Quote
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }

    }
}
