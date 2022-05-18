using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyProject2.Models;

namespace MyProject2.Data;

public class MyProject2Context : IdentityDbContext<IdentityUser>
{
    public MyProject2Context(DbContextOptions<MyProject2Context> options)
        : base(options)
    {
    }
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Post> Posts { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

        builder.Entity<Post>()
    .HasOne(p => p.Blog)
    .WithMany(b => b.Posts);
    }
}
