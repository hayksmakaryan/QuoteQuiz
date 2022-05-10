using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamousQuoteQuiz.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApiController : Controller
    {
        private IMediator _mediator;
        protected IMediator Mediator => _mediator ??= (IMediator)HttpContext.RequestServices.GetService(typeof(IMediator));
    }

}
