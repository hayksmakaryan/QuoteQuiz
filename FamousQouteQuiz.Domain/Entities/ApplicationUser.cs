using FamousQouteQuiz.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace FamousQuoteQuiz.Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public IList<Round> Rounds { get; set; }
    }
}
