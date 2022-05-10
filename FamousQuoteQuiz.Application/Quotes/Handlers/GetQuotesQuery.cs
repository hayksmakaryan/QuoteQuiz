using FamousQuoteQuiz.Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamousQuoteQuiz.Application.Quotes.Handlers
{
    public class GetQuotesQuery : IRequest<IList<QuoteVM>>
    {
    }
}
