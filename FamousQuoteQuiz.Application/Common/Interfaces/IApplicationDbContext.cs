using FamousQouteQuiz.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FamousQuoteQuiz.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Quote> Quotes { get; set; }

        DbSet<Author> Authors { get; set; }
        DbSet<Round> Rounds { get; set; }
        DbSet<Question> Questions { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
