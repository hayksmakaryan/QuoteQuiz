using FamousQouteQuiz.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamousQuoteQuiz.Application.ViewModels
{
    public class RoundVM
    {

            public RoundVM()
            {
                this.Questions = new List<QuestionVM>();
            }
            public int Id { get; set; }
            public string UserId { get; set; }
            public Mode Mode { get; set; }
            public DateTime StartDate { get; set; }
            public bool Comlpeted { get; set; }
            public IList<QuestionVM> Questions { get; set; }

    }
}
