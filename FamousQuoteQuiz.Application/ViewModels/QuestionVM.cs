using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamousQuoteQuiz.Application.ViewModels
{
    public class QuestionVM
    {
        public int Id { get; set; }
        public int QouteId { get; set; }
        public string UserAnswer { get; set; }
        public bool Result { get; set; }
    }
}
