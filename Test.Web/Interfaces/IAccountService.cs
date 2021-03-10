using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.Data.Entities;
using Test.Web.Models;

namespace Test.Web.Interfaces
{
    public interface IAccountService
    {
        Task<ApplicationUser> CreateUsersAsync(RegisterModel model);
    }
}
