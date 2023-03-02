﻿// <auto-generated />
using System;
using EFCoreAPIData.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCoreAPIData.Database.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230302114731_InitCreate")]
    partial class InitCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFCoreAPIData.Database.Entities.AudEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("QuoteFK")
                        .HasColumnType("int");

                    b.Property<double>("Volume24H")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("QuoteFK")
                        .IsUnique()
                        .HasFilter("[QuoteFK] IS NOT NULL");

                    b.ToTable("AUD", (string)null);
                });

            modelBuilder.Entity("EFCoreAPIData.Database.Entities.CadEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("QuoteFK")
                        .HasColumnType("int");

                    b.Property<double>("Volume24H")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("QuoteFK")
                        .IsUnique()
                        .HasFilter("[QuoteFK] IS NOT NULL");

                    b.ToTable("CAD", (string)null);
                });

            modelBuilder.Entity("EFCoreAPIData.Database.Entities.GbpEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("QuoteFK")
                        .HasColumnType("int");

                    b.Property<double>("Volume24H")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("QuoteFK")
                        .IsUnique()
                        .HasFilter("[QuoteFK] IS NOT NULL");

                    b.ToTable("GBP", (string)null);
                });

            modelBuilder.Entity("EFCoreAPIData.Database.Entities.JpyEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("QuoteFK")
                        .HasColumnType("int");

                    b.Property<double>("Volume24H")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("QuoteFK")
                        .IsUnique()
                        .HasFilter("[QuoteFK] IS NOT NULL");

                    b.ToTable("JPY", (string)null);
                });

            modelBuilder.Entity("EFCoreAPIData.Database.Entities.MarketEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BaseAsset")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Change24H")
                        .HasColumnType("float");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("ExchangeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MarketViewModelFK")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("PriceUnconverted")
                        .HasColumnType("float");

                    b.Property<string>("QuoteAsset")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Spread")
                        .HasColumnType("float");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Symbol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<double>("Volume24H")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("MarketViewModelFK");

                    b.ToTable("Markets", (string)null);
                });

            modelBuilder.Entity("EFCoreAPIData.Database.Entities.MarketsViewModelEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("Market", (string)null);
                });

            modelBuilder.Entity("EFCoreAPIData.Database.Entities.NzdEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("QuoteFK")
                        .HasColumnType("int");

                    b.Property<double>("Volume24H")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("QuoteFK")
                        .IsUnique()
                        .HasFilter("[QuoteFK] IS NOT NULL");

                    b.ToTable("NZD", (string)null);
                });

            modelBuilder.Entity("EFCoreAPIData.Database.Entities.QuoteEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("MarketFK")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MarketFK")
                        .IsUnique()
                        .HasFilter("[MarketFK] IS NOT NULL");

                    b.ToTable("Quote", (string)null);
                });

            modelBuilder.Entity("EFCoreAPIData.Database.Entities.UsdEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("QuoteFK")
                        .HasColumnType("int");

                    b.Property<double>("Volume24H")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("QuoteFK")
                        .IsUnique()
                        .HasFilter("[QuoteFK] IS NOT NULL");

                    b.ToTable("USD", (string)null);
                });

            modelBuilder.Entity("EFCoreAPIData.Database.Entities.AudEntity", b =>
                {
                    b.HasOne("EFCoreAPIData.Database.Entities.QuoteEntity", "Quote")
                        .WithOne("AUD")
                        .HasForeignKey("EFCoreAPIData.Database.Entities.AudEntity", "QuoteFK")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Quote");
                });

            modelBuilder.Entity("EFCoreAPIData.Database.Entities.CadEntity", b =>
                {
                    b.HasOne("EFCoreAPIData.Database.Entities.QuoteEntity", "Quote")
                        .WithOne("CAD")
                        .HasForeignKey("EFCoreAPIData.Database.Entities.CadEntity", "QuoteFK")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Quote");
                });

            modelBuilder.Entity("EFCoreAPIData.Database.Entities.GbpEntity", b =>
                {
                    b.HasOne("EFCoreAPIData.Database.Entities.QuoteEntity", "Quote")
                        .WithOne("GBP")
                        .HasForeignKey("EFCoreAPIData.Database.Entities.GbpEntity", "QuoteFK")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Quote");
                });

            modelBuilder.Entity("EFCoreAPIData.Database.Entities.JpyEntity", b =>
                {
                    b.HasOne("EFCoreAPIData.Database.Entities.QuoteEntity", "Quote")
                        .WithOne("JPY")
                        .HasForeignKey("EFCoreAPIData.Database.Entities.JpyEntity", "QuoteFK")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Quote");
                });

            modelBuilder.Entity("EFCoreAPIData.Database.Entities.MarketEntity", b =>
                {
                    b.HasOne("EFCoreAPIData.Database.Entities.MarketsViewModelEntity", "MarketViewModelEntity")
                        .WithMany("Markets")
                        .HasForeignKey("MarketViewModelFK")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("MarketViewModelEntity");
                });

            modelBuilder.Entity("EFCoreAPIData.Database.Entities.NzdEntity", b =>
                {
                    b.HasOne("EFCoreAPIData.Database.Entities.QuoteEntity", "Quote")
                        .WithOne("NZD")
                        .HasForeignKey("EFCoreAPIData.Database.Entities.NzdEntity", "QuoteFK")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Quote");
                });

            modelBuilder.Entity("EFCoreAPIData.Database.Entities.QuoteEntity", b =>
                {
                    b.HasOne("EFCoreAPIData.Database.Entities.MarketEntity", "MarketEntity")
                        .WithOne("Quotes")
                        .HasForeignKey("EFCoreAPIData.Database.Entities.QuoteEntity", "MarketFK")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("MarketEntity");
                });

            modelBuilder.Entity("EFCoreAPIData.Database.Entities.UsdEntity", b =>
                {
                    b.HasOne("EFCoreAPIData.Database.Entities.QuoteEntity", "Quote")
                        .WithOne("USD")
                        .HasForeignKey("EFCoreAPIData.Database.Entities.UsdEntity", "QuoteFK")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Quote");
                });

            modelBuilder.Entity("EFCoreAPIData.Database.Entities.MarketEntity", b =>
                {
                    b.Navigation("Quotes")
                        .IsRequired();
                });

            modelBuilder.Entity("EFCoreAPIData.Database.Entities.MarketsViewModelEntity", b =>
                {
                    b.Navigation("Markets");
                });

            modelBuilder.Entity("EFCoreAPIData.Database.Entities.QuoteEntity", b =>
                {
                    b.Navigation("AUD")
                        .IsRequired();

                    b.Navigation("CAD")
                        .IsRequired();

                    b.Navigation("GBP")
                        .IsRequired();

                    b.Navigation("JPY")
                        .IsRequired();

                    b.Navigation("NZD")
                        .IsRequired();

                    b.Navigation("USD")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
