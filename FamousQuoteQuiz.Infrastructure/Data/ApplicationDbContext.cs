using FamousQouteQuiz.Domain.Entities;
using FamousQuoteQuiz.Application.Common.Interfaces;
using FamousQuoteQuiz.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FamousQuoteQuiz.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Round> Rounds { get; set; }
        public DbSet<Question> Questions { get; set; }


        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);

        //    builder.Entity<ApplicationUser>()
        //        .Property(u => u.Rounds).IsRequired();
        //}

    }
}
