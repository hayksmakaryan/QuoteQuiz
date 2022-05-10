using FamousQuoteQuiz.Application.Common.Interfaces;
using FamousQuoteQuiz.Application.Quotes.Handlers;
using FamousQuoteQuiz.Application.ViewModels;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FamousQuoteQuiz.Application.Quotes.Queries
{
    public class GetQouteQueryHandler : IRequestHandler<GetQuotesQuery, IList<QuoteVM>>
    {
        private readonly IApplicationDbContext _context;


        public GetQouteQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IList<QuoteVM>> Handle(GetQuotesQuery request, CancellationToken cancellationToken)
        {
            var quotes = await _context.Quotes.Include(u => u.Author).ToListAsync();
            var vm = quotes.Select(i => new QuoteVM
            {
                Id = i.Id,
                Text = i.Text,
                Author = new AuthorVM {Id=i.AuthorId, Name =i.Author.Name }
                
            }).ToList();
            return vm;
        }
    }
}
