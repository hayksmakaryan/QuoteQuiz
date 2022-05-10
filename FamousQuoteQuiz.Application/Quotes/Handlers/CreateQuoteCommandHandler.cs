using FamousQouteQuiz.Domain.Entities;
using FamousQuoteQuiz.Application.Common.Interfaces;
using FamousQuoteQuiz.Application.Quotes.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FamousQuoteQuiz.Application.Quotes.Handlers
{
    public class CreateQuoteCommandHandler : IRequestHandler<CreateQuoteCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public CreateQuoteCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateQuoteCommand request, CancellationToken cancellationToken)
        {
            var entity = new Quote
            {
                Text = request.Text,
                AuthorId = request.AuthorId
            };

            _context.Quotes.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return entity.Id;
        }
    }
}
