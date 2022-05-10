using AutoMapper;
using FamousQuoteQuiz.Application.Common.Interfaces;
using FamousQuoteQuiz.Application.Users.Queries;
using FamousQuoteQuiz.Application.ViewModels;
using FamousQuoteQuiz.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FamousQuoteQuiz.Application.Users.Handlers
{
    public class GetUsersQueryHandler : IRequestHandler<GetUsersQuery, IList<ApplicationUserVM>>
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;


        public GetUsersQueryHandler( UserManager<ApplicationUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<IList<ApplicationUserVM>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
        {
            var result = new List<ApplicationUserVM>();
            var users = await _userManager.Users.Include(u => u.Rounds).ThenInclude(r=>r.Questions).ToListAsync();
            if(users != null)
            {
                result = _mapper.Map<List<ApplicationUserVM>>(users);
            }
            return result;
        }
    }
}
