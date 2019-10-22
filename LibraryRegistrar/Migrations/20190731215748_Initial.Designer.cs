﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using LibraryRegistrar.Models;

namespace LibraryRegistrar.Migrations
{
    [DbContext(typeof(LibraryRegistrarContext))]
    [Migration("20190731215748_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LibraryRegistrar.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("LibraryRegistrar.Models.CategoryItem", b =>
                {
                    b.Property<int>("CategoryItemId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryId");

                    b.Property<int>("ItemId");

                    b.HasKey("CategoryItemId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ItemId");

                    b.ToTable("CategoryItem");
                });

            modelBuilder.Entity("LibraryRegistrar.Models.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.HasKey("ItemId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("LibraryRegistrar.Models.CategoryItem", b =>
                {
                    b.HasOne("LibraryRegistrar.Models.Category", "Category")
                        .WithMany("Items")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LibraryRegistrar.Models.Item", "Item")
                        .WithMany("Categories")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}