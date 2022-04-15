﻿// <auto-generated />
using FinalExam.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FinalExam.Migrations
{
    [DbContext(typeof(QuotesDbContext))]
    partial class QuotesDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.24");

            modelBuilder.Entity("FinalExam.Models.Quote", b =>
                {
                    b.Property<int>("QuoteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Citation")
                        .HasColumnType("TEXT");

                    b.Property<string>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Subject")
                        .HasColumnType("TEXT");

                    b.Property<string>("Words")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("QuoteID");

                    b.ToTable("Quotes");
                });
#pragma warning restore 612, 618
        }
    }
}
