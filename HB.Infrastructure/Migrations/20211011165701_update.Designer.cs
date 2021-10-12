﻿// <auto-generated />
using System;
using HB.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HB.Infrastructure.Migrations
{
    [DbContext(typeof(HbContext))]
    [Migration("20211011165701_update")]
    partial class update
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HB.Domain.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ParentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("isActive")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("HB.Domain.Entities.Firm", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FirmType")
                        .HasColumnType("int");

                    b.Property<string>("ManagerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Firms");
                });

            modelBuilder.Entity("HB.Domain.Entities.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("HB.Domain.Entities.OrderItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Order_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<Guid>("StockItem_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Tax")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("StockItem_Id");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("HB.Domain.Entities.Stock", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CriticNumber")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<Guid>("StockItem_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("StockItem_Id");

                    b.ToTable("Stocks");
                });

            modelBuilder.Entity("HB.Domain.Entities.StockItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<string>("SerieNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("StockItems");
                });

            modelBuilder.Entity("HB.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("HB.Domain.Entities.Category", b =>
                {
                    b.HasOne("HB.Domain.Entities.Category", null)
                        .WithMany("SubCategories")
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("HB.Domain.Entities.OrderItem", b =>
                {
                    b.HasOne("HB.Domain.Entities.StockItem", "StockItem")
                        .WithMany()
                        .HasForeignKey("StockItem_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StockItem");
                });

            modelBuilder.Entity("HB.Domain.Entities.Stock", b =>
                {
                    b.HasOne("HB.Domain.Entities.StockItem", "StockItem")
                        .WithMany()
                        .HasForeignKey("StockItem_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StockItem");
                });

            modelBuilder.Entity("HB.Domain.Entities.StockItem", b =>
                {
                    b.HasOne("HB.Domain.Entities.Category", "Category")
                        .WithMany("StockItem")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("HB.Domain.Entities.Category", b =>
                {
                    b.Navigation("StockItem");

                    b.Navigation("SubCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
