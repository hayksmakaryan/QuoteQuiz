using FamousQouteQuiz.Domain.Entities;
using FamousQuoteQuiz.Application.Authors.Commands;
using FamousQuoteQuiz.Application.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FamousQuoteQuiz.Application.Authors.Handlers
{
    public class CreateAuthorCommandHandler : IRequestHandler<CreateAuthorCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public CreateAuthorCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<int> Handle(CreateAuthorCommand request, CancellationToken cancellationToken)
        {
            var entity = new Author
            {
                Name = request.Name,
            };

            _context.Authors.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return entity.Id;
        }
    }
}
