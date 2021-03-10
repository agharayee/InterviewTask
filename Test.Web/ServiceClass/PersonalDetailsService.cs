using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Test.Data;
using Test.Data.Entities;
using Test.Web.Interfaces;

namespace Test.Web.ServiceClass
{
    public class PersonalDetailsService : IPersonalDetials
    {
        private readonly ApplicationDbContext _context;

        public PersonalDetailsService(ApplicationDbContext context)
        {
            _context = context;
        }
        public void AddPersonnalDetails(IFormFile files)
        {
            //personDetails;
        }
    }
}

