using FamousQuoteQuiz.Application.ViewModels;
using MediatR;
using System.Collections.Generic;

namespace FamousQuoteQuiz.Application.Users.Queries
{
    public class GetUsersQuery : IRequest<IList<ApplicationUserVM>>
    {
        
    }
}
