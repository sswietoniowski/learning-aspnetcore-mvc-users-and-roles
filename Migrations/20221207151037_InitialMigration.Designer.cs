﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using learning_aspnetcore_mvc_users_and_logins.DataAccess;

#nullable disable

namespace learningaspnetcoremvcusersandlogins.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221207151037_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("learning_aspnetcore_mvc_users_and_logins.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Product")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Price = 1.0m,
                            Product = "Product 1",
                            Quantity = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Price = 2.0m,
                            Product = "Product 2",
                            Quantity = 2,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("learning_aspnetcore_mvc_users_and_logins.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<string>("PasswordSalt")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PasswordHash = "RQpV1PiU2EFqV3UbdkOcSBUYoHxcnGQN2+1GQF5/OCY=",
                            PasswordSalt = "f7/Oykm9xyJpl5e1iZEHog==",
                            Role = "Customer",
                            UserName = "jdoe"
                        },
                        new
                        {
                            Id = 2,
                            PasswordHash = "0SfNgIl6NqsCSLVJaKJnU20wZ+efjl3gi14mIH7VQmc=",
                            PasswordSalt = "3TrBaABPseX0YjxXw4LN9A==",
                            Role = "Employee",
                            UserName = "afox"
                        });
                });

            modelBuilder.Entity("learning_aspnetcore_mvc_users_and_logins.Entities.Order", b =>
                {
                    b.HasOne("learning_aspnetcore_mvc_users_and_logins.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}