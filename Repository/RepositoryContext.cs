using Entities.Models;
//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
//using Repository.Configuration;

namespace Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }




        public DbSet<Summary>? Summaries { get; set; }
        public DbSet<Timestamp>? Timestamps { get; set; }
        public DbSet<Video>? Videos { get; set; }

    }
}