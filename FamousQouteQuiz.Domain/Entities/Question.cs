using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamousQouteQuiz.Domain.Entities
{
    public class Question
    {
        public int Id { get; set; }
        public int RoundId { get; set; }
        public int QouteId { get; set; }
        public string UserAnswer { get; set; }
        public bool Result { get; set; }
        public Round Round { get; set; }
    }
}
