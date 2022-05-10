using FamousQuoteQuiz.Application.Users.Queries;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FamousQuoteQuiz.Api.Controllers
{
    [Authorize(Roles = "admin")]
    [Route("api/[controller]/[action]")]
    public class UsersController : ApiController
    {

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var users = await Mediator.Send(new GetUsersQuery());
            return View(users);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var users =  await Mediator.Send(new GetUsersQuery());
            return View("Users", users);

        }
    }
}
