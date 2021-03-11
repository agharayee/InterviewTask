using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.Data;
using Test.Data.Entities;
using Test.Web.Interfaces;
using Test.Web.Models;

namespace Test.Web.ServiceClass
{
    public class QuestionService : IQuestion
    {
        private readonly ApplicationDbContext _context;

        public QuestionService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddQuestion(Questions model)
        {
            var question = new QuestionModel
            {
               Question = model.Question,
               Answer = model.Answer,
               Option1 = model.Option1,
               Option2 = model.Option2,
               Option3 = model.Option3,
               Option4 = model.Option4,
               Results = model.Results
            };
            await  _context.AddAsync(question);
            await _context.SaveChangesAsync();
        }
    }
}
