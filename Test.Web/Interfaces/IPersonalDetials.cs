using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.Data.Entities;

namespace Test.Web.Interfaces
{
    public interface IPersonalDetials
    {
        void AddPersonnalDetails(IFormFile files);
    }
}
