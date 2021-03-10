using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Data.Entities;
using Test.Web.Interfaces;
using Test.Web.Models;

namespace Test.Web.ServiceClass
{
    public class AccountServices : IAccountService
    {
        public readonly UserManager<ApplicationUser> _userManager;

        public AccountServices(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<ApplicationUser> CreateUsersAsync(RegisterModel model)
        {
            if(model is null)
            {
                throw new ArgumentNullException(message: "Invalid Details Provided", null);
            }
            var user = new ApplicationUser
            {
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName
            };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
            {
                throw new InvalidOperationException(message: AddError(result), null);
            }
            return user;
        }
        private string AddError(IdentityResult result)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var errors in result.Errors)
            {
                sb.Append(errors.Description + " ");
            }
            return sb.ToString();
        }

    }
}
