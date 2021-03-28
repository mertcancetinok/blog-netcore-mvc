using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
namespace blog.entity
{
    public partial class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options):base(options)
        {

        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<BlogCategory> BlogCategories{ get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            

            //Many to many
            modelBuilder.Entity<BlogCategory>()
                .HasKey(bc => new { bc.BlogId, bc.CategoryId });
            modelBuilder.Entity<BlogCategory>()
                .HasOne(bc => bc.Blog)
                .WithMany(b => b.BlogCategories)
                .HasForeignKey(bc => bc.BlogId);

            modelBuilder.Entity<BlogCategory>()
                .HasOne(bc => bc.Category)
                .WithMany(c => c.BlogCategories)
                .HasForeignKey(bc => bc.CategoryId);
        }


    }
}
