using FamousQuoteQuiz.Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamousQuoteQuiz.Application.Authors.Queries
{
    public class GetAuthorsQuery : IRequest<IList<AuthorVM>>
    {
    }
}
