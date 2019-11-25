﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(BaseAppDbContext))]
    partial class BaseAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataAccess.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Avatar");

                    b.Property<DateTime>("Birthday");

                    b.Property<string>("Countru");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Logo");

                    b.Property<string>("Status");

                    b.HasKey("Id");

                    b.ToTable("User");
                });
        }
    }
}
