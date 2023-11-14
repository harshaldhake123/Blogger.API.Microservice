﻿// <auto-generated />
using Blogger.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Blogger.Infrastructure.Database.Migrations;

[DbContext(typeof(BloggerDbContext))]
[Migration("20231112190218_InitialCreate")]
partial class InitialCreate
{
    /// <inheritdoc />
    protected override void BuildTargetModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
        modelBuilder
            .HasAnnotation("ProductVersion", "7.0.13")
            .HasAnnotation("Relational:MaxIdentifierLength", 128);

        SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

        modelBuilder.Entity("Blogger.UseCases.Core.Entities.User", b =>
            {
                b.Property<long>("ID")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("bigint");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                b.Property<string>("EmailAddress")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("FirstName")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("nvarchar(100)");

                b.Property<string>("LastName")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("nvarchar(100)");

                b.Property<string>("Password")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("ID");

                b.ToTable("User");
            });
#pragma warning restore 612, 618
    }
}
