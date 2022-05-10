using FamousQouteQuiz.Domain.Entities;
using FamousQuoteQuiz.Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamousQuoteQuiz.Application.Quotes.Commands
{
    public class CreateQuoteCommand: IRequest<int>
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int AuthorId { get; set; }
        public AuthorVM Author { get; set; }
    }
}
