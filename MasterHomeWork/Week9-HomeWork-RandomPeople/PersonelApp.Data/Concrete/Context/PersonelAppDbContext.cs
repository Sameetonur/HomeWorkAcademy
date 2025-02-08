using System;
using Microsoft.EntityFrameworkCore;
using PersonelApp.Entity.Concrete;

namespace PersonelApp.Data.Concrete.Context;

public class PersonelAppDbContext : DbContext
{

    public PersonelAppDbContext(DbContextOptions<PersonelAppDbContext> options): base(options)
    {

    }

    public DbSet<Person> Persons { get; set; }
    public DbSet<Group> Groups { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>()
            .HasOne(p => p.Group)
            .WithMany(g => g.People)
            .HasForeignKey(p => p.GroupId);
    }

}
