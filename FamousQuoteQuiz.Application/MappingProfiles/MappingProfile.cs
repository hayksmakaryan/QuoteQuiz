using AutoMapper;
using FamousQouteQuiz.Domain.Entities;
using FamousQuoteQuiz.Application.ViewModels;
using FamousQuoteQuiz.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamousQuoteQuiz.Application.MappingProfiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ApplicationUser, ApplicationUserVM>();
            CreateMap<Round, RoundVM>();
            CreateMap<Question, QuestionVM>();
        }
    }
}
