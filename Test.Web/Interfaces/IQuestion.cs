using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.Data.Entities;

namespace Test.Web.Interfaces
{
    public interface IQuestion
    {
        Task AddQuestion(Questions model);
    }
}
