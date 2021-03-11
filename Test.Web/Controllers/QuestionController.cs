using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.Data;
using Test.Data.Entities;
using Test.Web.Interfaces;
using Test.Web.Models;

namespace Test.Web.Controllers
{
    public class QuestionController : Controller
    {
        public readonly ApplicationDbContext _context;
        private readonly IQuestion _question;

        public QuestionController(IQuestion question, ApplicationDbContext context)
        {
            _question = question;
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Questions model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            try
            {
                await _question.AddQuestion(model);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                ModelState.AddModelError("Entry was not saved please try again", e.Message);
                return RedirectToAction(nameof(Index));
            }
        }
    }
}
