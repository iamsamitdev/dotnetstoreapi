// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MySQLStoreAPI.Models;

namespace MySQLStoreAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211127162233_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("MySQLStoreAPI.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("varchar(64)")
                        .HasColumnName("CategoryName");

                    b.Property<int>("CategoryStatus")
                        .HasColumnType("int");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");

                    b
                        .HasComment("Category table data");
                });

            modelBuilder.Entity("MySQLStoreAPI.Models.Products", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("varchar(64)");

                    b.Property<string>("ProductPicture")
                        .IsRequired()
                        .HasColumnType("varchar(128)");

                    b.Property<int>("UnitInStock")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b
                        .HasComment("Products table data");
                });

            modelBuilder.Entity("MySQLStoreAPI.Models.Products", b =>
                {
                    b.HasOne("MySQLStoreAPI.Models.Category", "CategoryInfo")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategoryInfo");
                });
#pragma warning restore 612, 618
        }
    }
}
