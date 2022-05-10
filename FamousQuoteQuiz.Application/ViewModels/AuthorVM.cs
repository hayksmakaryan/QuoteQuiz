using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamousQuoteQuiz.Application.ViewModels
{
    public class AuthorVM
    {
        public AuthorVM()
        {
            this.Quotes = new List<QuoteVM>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public IList<QuoteVM> Quotes { get; set; }
    }
}
