using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Test.Data;
using Test.Data.Entities;
using Test.Web.Interfaces;
using Test.Web.Models;

namespace Test.Web.Controllers
{
    public class PersonalDetailsController : Controller
    {
        private readonly ApplicationDbContext _context;
        //private readonly IPersonalDetials details;
        public PersonalDetailsController(ApplicationDbContext context)
        {
            _context = context;
            //details = _details;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(IFormFile files)
        {
            if (files != null)
            {
                if (files.Length > 0)
                {

                    var CvFileName = Path.GetFileName(files.FileName);
                    var CvExtension = Path.GetExtension(CvFileName);
                    var newCvName = string.Concat(Convert.ToString(Guid.NewGuid()), CvExtension);
                    var personDetails = new PersonalDetails()
                    {

                        CVFileName = newCvName,
                        CVFileType = CvExtension,
                        CreatedOn = DateTime.Now
                    };
                    using (var target = new MemoryStream())
                    {
                        files.CopyTo(target);
                        personDetails.CVFiles = target.ToArray();
                    }
                    _context.personalDetails.Add(personDetails);
                    _context.SaveChanges();
                }
            }

            return View();

        }
    }
}
