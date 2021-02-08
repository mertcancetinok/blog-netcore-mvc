using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;



namespace blog.entity
{
    public partial class BlogContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Blogger> Bloggers { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<BlogCategory> BlogCategories{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer("Server=DESKTOP-OJ7358A;Database=Blog;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //One to one
            modelBuilder.Entity<Blogger>()
                .HasMany(b => b.Blog)
                .WithOne(bg => bg.Blogger);

            //One to many
            modelBuilder.Entity<Blog>()
                .HasMany(c => c.Comments)
                .WithOne(b => b.Blog);

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
