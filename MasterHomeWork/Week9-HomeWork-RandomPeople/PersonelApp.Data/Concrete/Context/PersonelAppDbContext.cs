using System;
using Microsoft.EntityFrameworkCore;
using PersonelApp.Entity.Concrete;

namespace PersonelApp.Data.Concrete.Context;

public class PersonelAppDbContext : DbContext
{

    public PersonelAppDbContext(DbContextOptions<PersonelAppDbContext> options) : base(options)
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

        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasData(
                    new Person
                    {
                        Id = 1,
                        Name = "Samet",
                        Surname = "Önür",
                        Email = "samet@gmail.com",
                    },
                    new Person
                    {
                        Id = 2,
                        Name = "Elif",
                        Surname = "Binici",
                        Email = "samet@gmail.com",
                    }, new Person
                    {
                        Id = 3,
                        Name = "Aleyna",
                        Surname = "Çelen",
                        Email = "samet@gmail.com",
                    },
                    new Person
                    {
                        Id = 4,
                        Name = "Burhan",
                        Surname = "Torun",
                        Email = "samet@gmail.com",
                    },
                    new Person
                    {
                        Id = 5,
                        Name = "Emre",
                        Surname = "Kılıç",
                        Email = "samet@gmail.com",
                    },
                    new Person
                    {
                        Id = 6,
                        Name = "Doğukhan",
                        Surname = "Babayiğit",
                        Email = "samet@gmail.com",
                    },
                    new Person
                    {
                        Id = 7,
                        Name = "Kerem",
                        Surname = "Kırpar",
                        Email = "samet@gmail.com",
                    },
                    new Person
                    {
                        Id = 8,
                        Name = "Burak",
                        Surname = "Avar",
                        Email = "samet@gmail.com",
                    },
                    new Person
                    {
                        Id = 9,
                        Name = "Enes",
                        Surname = "Aydemir",
                        Email = "samet@gmail.com",
                    },
                    new Person
                    {
                        Id = 10,
                        Name = "Emin",
                        Surname = "Demir",
                        Email = "samet@gmail.com",
                    },
                    new Person
                    {
                        Id = 11,
                        Name = "Bedirhan",
                        Surname = "---",
                        Email = "samet@gmail.com",
                    },
                    new Person
                    {
                        Id = 12,
                        Name = "Yücel",
                        Surname = "---",
                        Email = "samet@gmail.com",
                    }
                );



        });
        base.OnModelCreating(modelBuilder);
    }

}
