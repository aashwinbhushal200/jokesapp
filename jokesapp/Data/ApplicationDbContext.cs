using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using jokesapp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace jokesapp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<jokesapp.Models.Joke> Joke { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //add this after adding IdentityDbContext

            base.OnModelCreating(builder);
        }
    }   
}
