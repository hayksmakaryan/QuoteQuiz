using FamousQuoteQuiz.Application.Authors.Queries;
using FamousQuoteQuiz.Application.Common.Interfaces;
using FamousQuoteQuiz.Application.ViewModels;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FamousQuoteQuiz.Application.Authors.Handlers
{
    public class GetAuthorsQueryHandler : IRequestHandler<GetAuthorsQuery, IList<AuthorVM>>
    {
        private readonly IApplicationDbContext _context;

        public GetAuthorsQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IList<AuthorVM>> Handle(GetAuthorsQuery request, CancellationToken cancellationToken)
        {
            var authors = await _context.Authors.Include(i => i.Quotes).ToListAsync();
            var vm = authors.Select(i => new AuthorVM
            {
                
                Id = i.Id,
                Name = i.Name,
                Quotes = i.Quotes.Select(i => new QuoteVM
                {
                    Id = i.Id,
                    Text = i.Text,
                }).ToList()
            }).ToList();
            return vm;
        }
    }
}
