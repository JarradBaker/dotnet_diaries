using System;
using Microsoft.EntityFrameworkCore;
using DOTNET_DIARIES.Models;

namespace DOTNET_DIARIES.Data;

public class DOTNET_DIARIES_Context : DbContext
{
    public DOTNET_DIARIES_Context(DbContextOptions<DOTNET_DIARIES_Context> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BlogpostTag>().HasKey(bt => new 
        { 
            bt.BlogpostId, 
            bt.TagId 
        });

        modelBuilder.Entity<BlogpostTag>()
            .HasOne(b => b.Blogpost)
            .WithMany(bt => bt.BlogpostTags)
            .HasForeignKey(b => b.BlogpostId);

        modelBuilder.Entity<BlogpostTag>()
            .HasOne(t => t.Tag)
            .WithMany(bt => bt.BlogpostTags)
            .HasForeignKey(t => t.BlogpostId);

        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Blogpost> Blogposts { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<BlogpostTag> BlogpostTags { get; set; }

    
}
