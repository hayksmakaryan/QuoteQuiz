using FamousQuoteQuiz.Application.Authors.Commands;
using FamousQuoteQuiz.Application.Authors.Queries;
using FamousQuoteQuiz.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamousQuoteQuiz.Api.Controllers
{
    [Authorize]
    public class AuthorsController : ApiController
    {
        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateAuthorCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpGet]
        public async Task<IList<AuthorVM>> Get()
        {
            return await Mediator.Send(new GetAuthorsQuery());
        }
    }
}
