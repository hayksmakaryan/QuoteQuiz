using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamousQuoteQuiz.Application.ViewModels
{
    public class ApplicationUserVM
    {
        public ApplicationUserVM()
        {
            this.Rounds = new List<RoundVM>();
        }
        public string ID { get; set; }
        public string UserName { get; set; }


        public IList<RoundVM> Rounds { get; set; }
    }
}
