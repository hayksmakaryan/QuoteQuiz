using FamousQuoteQuiz.Application.Quotes.Commands;
using FamousQuoteQuiz.Application.Quotes.Handlers;
using FamousQuoteQuiz.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamousQuoteQuiz.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    public class QuotesController : ApiController
    {

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var quotes = await Mediator.Send(new GetQuotesQuery());
            return View(quotes);
        }

        [Authorize(Roles = "admin")]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize(Roles = "admin")]
        [HttpPost]
        public async Task<IActionResult> Create([FromForm]CreateQuoteCommand command)
        {
            try
            {
                var id = await Mediator.Send(command);
                ViewBag.Result = true;
            }
            catch (Exception)
            {
                ViewBag.Result = false;
            }
            
            return View();

        }

        [HttpGet]
        public async Task<IList<QuoteVM>> GetAll()
        {
            return await Mediator.Send(new GetQuotesQuery());
        }
    }
}
