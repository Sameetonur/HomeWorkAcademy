﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PersonelApp.Data.Concrete.Context;

#nullable disable

namespace PersonelApp.Data.Migrations
{
    [DbContext(typeof(PersonelAppDbContext))]
    partial class PersonelAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PersonelApp.Entity.Concrete.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("PersonelApp.Entity.Concrete.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GroupId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonType")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "samet@gmail.com",
                            Name = "Samet",
                            PersonType = 0,
                            Surname = "Önür"
                        },
                        new
                        {
                            Id = 2,
                            Email = "samet@gmail.com",
                            Name = "Elif",
                            PersonType = 0,
                            Surname = "Binici"
                        },
                        new
                        {
                            Id = 3,
                            Email = "samet@gmail.com",
                            Name = "Aleyna",
                            PersonType = 0,
                            Surname = "Çelen"
                        },
                        new
                        {
                            Id = 4,
                            Email = "samet@gmail.com",
                            Name = "Burhan",
                            PersonType = 0,
                            Surname = "Torun"
                        },
                        new
                        {
                            Id = 5,
                            Email = "samet@gmail.com",
                            Name = "Emre",
                            PersonType = 0,
                            Surname = "Kılıç"
                        },
                        new
                        {
                            Id = 6,
                            Email = "samet@gmail.com",
                            Name = "Doğukhan",
                            PersonType = 0,
                            Surname = "Babayiğit"
                        },
                        new
                        {
                            Id = 7,
                            Email = "samet@gmail.com",
                            Name = "Kerem",
                            PersonType = 0,
                            Surname = "Kırpar"
                        },
                        new
                        {
                            Id = 8,
                            Email = "samet@gmail.com",
                            Name = "Burak",
                            PersonType = 0,
                            Surname = "Avar"
                        },
                        new
                        {
                            Id = 9,
                            Email = "samet@gmail.com",
                            Name = "Enes",
                            PersonType = 0,
                            Surname = "Aydemir"
                        },
                        new
                        {
                            Id = 10,
                            Email = "samet@gmail.com",
                            Name = "Emin",
                            PersonType = 0,
                            Surname = "Demir"
                        },
                        new
                        {
                            Id = 11,
                            Email = "samet@gmail.com",
                            Name = "Bedirhan",
                            PersonType = 0,
                            Surname = "---"
                        },
                        new
                        {
                            Id = 12,
                            Email = "samet@gmail.com",
                            Name = "Yücel",
                            PersonType = 0,
                            Surname = "---"
                        });
                });

            modelBuilder.Entity("PersonelApp.Entity.Concrete.Person", b =>
                {
                    b.HasOne("PersonelApp.Entity.Concrete.Group", "Group")
                        .WithMany("People")
                        .HasForeignKey("GroupId");

                    b.Navigation("Group");
                });

            modelBuilder.Entity("PersonelApp.Entity.Concrete.Group", b =>
                {
                    b.Navigation("People");
                });
#pragma warning restore 612, 618
        }
    }
}
