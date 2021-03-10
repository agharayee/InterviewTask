using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.Data.Entities;

namespace Test.Web.Models
{
    public class AddPersonnalDetailsViewModel
    {
        public int Id { get; set; }
        public string CVFileName { get; set; }
        public string CVFileType { get; set; }
        public byte[] CVFiles { get; set; }
        public DateTime? CreatedOn { get; set; }

        public virtual ApplicationUser users { get; set; }
    }
}
