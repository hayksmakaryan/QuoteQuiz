using FamousQouteQuiz.Domain.Enums;
using System;
using System.Collections.Generic;
using FamousQuoteQuiz.Domain.Entities;

namespace FamousQouteQuiz.Domain.Entities
{
    public class Round
    {
        public Round()
        {
            this.Questions = new List<Question>();
        }
        public int Id { get; set; }
        public string UserId { get; set; }
        public Mode Mode { get; set; }
        public DateTime StartDate { get; set; }
        public bool Comlpeted { get; set; }
        public ApplicationUser User { get; set; }
        public IList<Question> Questions { get; set; }

    }
}
