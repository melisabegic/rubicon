﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using blogCRUD.Context;

namespace blogCRUD.Migrations
{
    [DbContext(typeof(BlogContext))]
    partial class BlogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("blogCRUD.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body")
                        .IsRequired();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Slug");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("Posts");

                    b.HasData(
                        new { Id = 1, Body = "The app is simple to use, and will help you decide on your best furniture fit.", CreatedAt = new DateTime(2020, 3, 20, 14, 48, 46, 34, DateTimeKind.Local), Description = "Rubicon Software Development and Gazzda furniture are proud to launch an augmented reality app.", Slug = "augmented-reality-ios-application", Title = "augmented-reality-ios-application", UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                        new { Id = 2, Body = "The app is simple to use, and will help you decide on your best furniture fit.", CreatedAt = new DateTime(2020, 3, 20, 14, 48, 46, 37, DateTimeKind.Local), Description = "Rubicon Software Development and Gazzda furniture are proud to launch an augmented reality app.", Slug = "augmented-reality-ios-application-2", Title = "augmented-reality-ios-application-2", UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                    );
                });

            modelBuilder.Entity("blogCRUD.Models.PostTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PostId");

                    b.Property<string>("TagId");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("TagId");

                    b.ToTable("PostTag");

                    b.HasData(
                        new { Id = 1, PostId = 1, TagId = "iOs" },
                        new { Id = 2, PostId = 1, TagId = "AR" },
                        new { Id = 3, PostId = 2, TagId = "iOs" },
                        new { Id = 4, PostId = 2, TagId = "AR" },
                        new { Id = 5, PostId = 2, TagId = "Gazzda" }
                    );
                });

            modelBuilder.Entity("blogCRUD.Models.Tag", b =>
                {
                    b.Property<string>("TagId")
                        .ValueGeneratedOnAdd();

                    b.HasKey("TagId");

                    b.ToTable("Tags");

                    b.HasData(
                        new { TagId = "iOs" },
                        new { TagId = "Gazzda" },
                        new { TagId = "AR" }
                    );
                });

            modelBuilder.Entity("blogCRUD.Models.PostTag", b =>
                {
                    b.HasOne("blogCRUD.Models.Post", "Post")
                        .WithMany()
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("blogCRUD.Models.Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
