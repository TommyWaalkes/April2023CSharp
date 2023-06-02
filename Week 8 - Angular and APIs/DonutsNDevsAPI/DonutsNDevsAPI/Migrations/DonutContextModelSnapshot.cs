﻿// <auto-generated />
using DonutsNDevsAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DonutsNDevsAPI.Migrations
{
    [DbContext(typeof(DonutContext))]
    partial class DonutContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DonutDetails", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("_ref")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "ref");

                    b.Property<int>("calories")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("photo_attribution")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("donutDetails");
                });

            modelBuilder.Entity("DonutExtras", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("DonutDetails")
                        .HasColumnType("int");

                    b.Property<int>("Extra")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("donutDetailsExtra");
                });

            modelBuilder.Entity("Extra", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("extra")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("extra");
                });

            modelBuilder.Entity("Result", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("photo_attribution")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ref")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("donutResults");
                });
#pragma warning restore 612, 618
        }
    }
}
