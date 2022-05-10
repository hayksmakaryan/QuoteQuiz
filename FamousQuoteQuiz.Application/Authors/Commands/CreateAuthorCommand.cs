using FamousQuoteQuiz.Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamousQuoteQuiz.Application.Authors.Commands
{
    public class CreateAuthorCommand: IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
