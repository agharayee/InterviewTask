using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Test.Data.Entities;

namespace Test.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ) : base(options)
        {
                
        }
        public DbSet<CertificateUploads> certificateUploads { get; set; }
        public DbSet<PersonalDetails> personalDetails { get; set; }
        public DbSet<Questions> questions { get; set; }
    }
}
