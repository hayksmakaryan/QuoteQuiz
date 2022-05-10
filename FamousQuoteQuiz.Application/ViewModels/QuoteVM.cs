using FamousQouteQuiz.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamousQuoteQuiz.Application.ViewModels
{
    public class QuoteVM
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public AuthorVM Author { get; set; }
    }
}
