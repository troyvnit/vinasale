using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using VinaSale.Models;

namespace VinaSale.DAL
{
    public class VinaSaleContext : DbContext
    {
        public VinaSaleContext()
            : base("VinaSaleContext")
        {
        }
        
        public DbSet<User> Users { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Media> Medias { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}