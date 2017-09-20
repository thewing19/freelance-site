using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using RickFreelanceWebApp.Models;

namespace RickFreelanceWebApp.Data
{
    public class FreelanceContext : DbContext
    {
        public FreelanceContext(DbContextOptions<FreelanceContext> options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().ToTable("Contact");
            modelBuilder.Entity<Address>().ToTable("Address");
        }
    }
}
